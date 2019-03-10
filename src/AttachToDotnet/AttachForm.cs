using AttachToDotnet.Infrastructure;
using EnvDTE80;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AttachToDotnet
{
    public partial class AttachForm : Form
    {
        public DTE2 DTE
        {
            get; set;
        }

        public AttachForm()
        {
            InitializeComponent();

            CreateColumns();
        }

        private void CreateColumns()
        {
            processesGridView.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProcessId",
                Name = "ProcessId",
                ReadOnly = true
            };
            processesGridView.Columns.Add(column);

            DataGridViewColumn column4 = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Program",
                Name = "Program",
                ReadOnly = true
            };
            processesGridView.Columns.Add(column4);

            DataGridViewColumn column2 = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CommandLine",
                Name = "CommandLine",
                ReadOnly = true
            };
            processesGridView.Columns.Add(column2);

            DataGridViewColumn column3 = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreationDate",
                Name = "CreationDate",
                ReadOnly = true
            };
            processesGridView.Columns.Add(column3);
        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            AttachToSelectedProcess();
        }

        private void AttachToSelectedProcess()
        {
            Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();
            var selectedRows = processesGridView.SelectedRows;
            uint processId = 0;
            var program = "";

            foreach (var row in selectedRows)
            {
                var datagridRow = (DataGridViewRow)row;
                dynamic process = datagridRow.DataBoundItem;
                processId = process.ProcessId;
                program = process.CommandLine;
            }

            if (processId <= 0)
            {
                return;
            }

            try
            {
                AttachService.AttachToProcess(DTE, processId, program);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to attach to process: " + ex.ToString());
            }
        }

        private void AttachForm_Load(object sender, EventArgs e)
        {
            CreateGrid();
            ShowReattachKeyBinding();
        }

        private void CreateGrid()
        {
            processesGridView.DataSource = null;

            var processes = Win32Process.GetProcesses().Where(x => IncludeInGrid(x)).ToList();

            var data = processes.Select(x => new { x.ProcessId, x.CommandLine, x.CreationDate, Program = ParseProgram(x.CommandLine) }).ToList();

            processesGridView.DataSource = data;
            processesGridView.ClearSelection();

            processesGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            processesGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            processesGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            processesGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (var i = 0; i <= processesGridView.Columns.Count - 1; i++)
            {
                var colw = processesGridView.Columns[i].Width;
                processesGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                processesGridView.Columns[i].Width = colw;
            }

            if (!data.Any())
            {
                return;
            }

            processesGridView.Rows[0].Selected = true;
        }

        private string ParseProgram(string commandLine)
        {
            if (string.IsNullOrWhiteSpace(commandLine))
            {
                return "";
            }

            commandLine = commandLine.Replace("\"", "");
            var pathparts = commandLine.Split('\\');
            if (!pathparts.Any())
            {
                return "";
            }

            var file = pathparts[pathparts.Length - 1];

            return file;
        }

        private bool IncludeInGrid(Win32Process process)
        {
            if (showAllCheckBox.Checked)
            {
                return true;
            }

            // Hide processes with empty commandline
            if (string.IsNullOrWhiteSpace(process.CommandLine))
            {
                return false;
            }

            // Hide processes without specific dll
            if (!process.CommandLine.Contains(".dll", StringComparison.InvariantCultureIgnoreCase))
            {
                return false;
            }

            if (process.CommandLine.Contains("dotnet-watch.dll", StringComparison.InvariantCultureIgnoreCase))
            {
                return false;
            }

            if (process.CommandLine.Contains("VBCSCompiler", StringComparison.InvariantCultureIgnoreCase))
            {
                return false;
            }

            return true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            CreateGrid();
        }

        private void showAll_CheckedChanged(object sender, EventArgs e)
        {
            CreateGrid();
        }

        private void ShowReattachKeyBinding()
        {
            try
            {
                Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();

                var reattachCommand = DTE.Commands.Item("b57a9e06-854a-444a-95d5-d4bff475f2ed", 256);

                var bindings = reattachCommand.Bindings;
                if (bindings != null)
                {
                    var keyBindingsString = ((object[])bindings)[0].ToString();
                    var keyBindings = keyBindingsString.Split(new string[] { "::" }, StringSplitOptions.None);

                    labelReattach.Text = $"Use {keyBindings.Last()} to reattach to previous dotnet.exe";
                }
            }
            catch (Exception)
            {
            }
        }

        private void ProcessesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AttachToSelectedProcess();
        }
    }


    public static class StringExtensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }
    }
}
