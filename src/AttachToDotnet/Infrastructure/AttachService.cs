using System.Linq;
using EnvDTE;
using EnvDTE80;

namespace AttachToDotnet.Infrastructure
{
    public class AttachService
    {
        public static string PreviousProgram;

        public static void AttachToProcess(DTE2 DTE, uint processId, string program)
        {
            Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();

            var localProcesses = DTE.Debugger.LocalProcesses;
            foreach (Process process in localProcesses)
            {
                if (process.ProcessID != processId)
                {
                    continue;
                }

                PreviousProgram = program;
                process.Attach();
            }
        }

        public static bool AttachToProgram(DTE2 DTE, string program)
        {
            Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();

            var processes = Win32Process.GetProcesses().ToList();

            var reattachedProcess = processes.FirstOrDefault(x => string.Equals(x.CommandLine, PreviousProgram));
            if (reattachedProcess == null)
            {
                return false;
            }

            var localProcesses = DTE.Debugger.LocalProcesses;
            foreach (Process localProcess in localProcesses)
            {
                if (localProcess.ProcessID != reattachedProcess.ProcessId)
                {
                    continue;
                }

                localProcess.Attach();

                return true;
            }

            return false;
        }
    }
}
