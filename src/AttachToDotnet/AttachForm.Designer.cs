namespace AttachToDotnet
{
    partial class AttachForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.processesGridView = new System.Windows.Forms.DataGridView();
            this.attachButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.processesGroupBox = new System.Windows.Forms.GroupBox();
            this.showAllCheckBox = new System.Windows.Forms.CheckBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.labelReattach = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.processesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.processesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // processesGridView
            // 
            this.processesGridView.AllowUserToAddRows = false;
            this.processesGridView.AllowUserToDeleteRows = false;
            this.processesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.processesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.processesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processesGridView.EnableHeadersVisualStyles = false;
            this.processesGridView.Location = new System.Drawing.Point(12, 36);
            this.processesGridView.Margin = new System.Windows.Forms.Padding(6);
            this.processesGridView.Name = "processesGridView";
            this.processesGridView.ReadOnly = true;
            this.processesGridView.RowHeadersVisible = false;
            this.processesGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.processesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.processesGridView.Size = new System.Drawing.Size(1550, 586);
            this.processesGridView.TabIndex = 0;
            this.processesGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProcessesGridView_CellDoubleClick);
            // 
            // attachButton
            // 
            this.attachButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.attachButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.attachButton.Location = new System.Drawing.Point(1288, 758);
            this.attachButton.Margin = new System.Windows.Forms.Padding(6);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(150, 44);
            this.attachButton.TabIndex = 1;
            this.attachButton.Text = "Attach";
            this.attachButton.UseVisualStyleBackColor = true;
            this.attachButton.Click += new System.EventHandler(this.attachButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(1450, 758);
            this.closeButton.Margin = new System.Windows.Forms.Padding(6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(150, 44);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Cancel";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // processesGroupBox
            // 
            this.processesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processesGroupBox.Controls.Add(this.showAllCheckBox);
            this.processesGroupBox.Controls.Add(this.refreshButton);
            this.processesGroupBox.Controls.Add(this.processesGridView);
            this.processesGroupBox.Location = new System.Drawing.Point(26, 25);
            this.processesGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.processesGroupBox.Name = "processesGroupBox";
            this.processesGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.processesGroupBox.Size = new System.Drawing.Size(1574, 691);
            this.processesGroupBox.TabIndex = 3;
            this.processesGroupBox.TabStop = false;
            this.processesGroupBox.Text = "Available dotnet.exe processes";
            // 
            // showAllCheckBox
            // 
            this.showAllCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showAllCheckBox.AutoSize = true;
            this.showAllCheckBox.Location = new System.Drawing.Point(14, 639);
            this.showAllCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.showAllCheckBox.Name = "showAllCheckBox";
            this.showAllCheckBox.Size = new System.Drawing.Size(337, 29);
            this.showAllCheckBox.TabIndex = 5;
            this.showAllCheckBox.Text = "Show all dotnet.exe processes";
            this.showAllCheckBox.UseVisualStyleBackColor = true;
            this.showAllCheckBox.CheckedChanged += new System.EventHandler(this.showAll_CheckedChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(1412, 634);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(6);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(150, 44);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // labelReattach
            // 
            this.labelReattach.AutoSize = true;
            this.labelReattach.Location = new System.Drawing.Point(21, 758);
            this.labelReattach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReattach.Name = "labelReattach";
            this.labelReattach.Size = new System.Drawing.Size(0, 25);
            this.labelReattach.TabIndex = 4;
            // 
            // AttachForm
            // 
            this.AcceptButton = this.attachButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(1624, 825);
            this.Controls.Add(this.labelReattach);
            this.Controls.Add(this.processesGroupBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.attachButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AttachForm";
            this.Text = "Attach to dotnet.exe";
            this.Load += new System.EventHandler(this.AttachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.processesGroupBox.ResumeLayout(false);
            this.processesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView processesGridView;
        private System.Windows.Forms.Button attachButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox processesGroupBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.CheckBox showAllCheckBox;
        private System.Windows.Forms.Label labelReattach;
    }
}
