using System;
using System.Linq;
using System.Management;

namespace AttachToDotnet
{
    public class Win32Process
    {
        public string Caption { get; set; }
        public string CommandLine { get; set; }
        public string CreationClassName { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CSCreationClassName { get; set; }
        public string CSName { get; set; }
        public string Description { get; set; }
        public string ExecutablePath { get; set; }
        public UInt16? ExecutionState { get; set; }
        public string Handle { get; set; }
        public UInt32? HandleCount { get; set; }
        public DateTime? InstallDate { get; set; }
        public UInt64? KernelModeTime { get; set; }
        public UInt32? MaximumWorkingSetSize { get; set; }
        public UInt32? MinimumWorkingSetSize { get; set; }
        public string Name { get; set; }
        public string OSCreationClassName { get; set; }
        public string OSName { get; set; }
        public UInt64? OtherOperationCount { get; set; }
        public UInt64? OtherTransferCount { get; set; }
        public UInt32? PageFaults { get; set; }
        public UInt32? PageFileUsage { get; set; }
        public UInt32? ParentProcessId { get; set; }
        public UInt32? PeakPageFileUsage { get; set; }
        public UInt64? PeakVirtualSize { get; set; }
        public UInt32? PeakWorkingSetSize { get; set; }
        public UInt32? Priority { get; set; }
        public UInt64? PrivatePageCount { get; set; }
        public UInt32? ProcessId { get; set; }
        public UInt32? QuotaNonPagedPoolUsage { get; set; }
        public UInt32? QuotaPagedPoolUsage { get; set; }
        public UInt32? QuotaPeakNonPagedPoolUsage { get; set; }
        public UInt32? QuotaPeakPagedPoolUsage { get; set; }
        public UInt64? ReadOperationCount { get; set; }
        public UInt64? ReadTransferCount { get; set; }
        public UInt32? SessionId { get; set; }
        public string Status { get; set; }
        public DateTime? TerminationDate { get; set; }
        public UInt32? ThreadCount { get; set; }
        public UInt64? UserModeTime { get; set; }
        public UInt64? VirtualSize { get; set; }
        public string WindowsVersion { get; set; }
        public UInt64? WorkingSetSize { get; set; }
        public UInt64? WriteOperationCount { get; set; }
        public UInt64? WriteTransferCount { get; set; }

        public static Win32Process[] GetProcesses()
        {
            using (var searcher = new ManagementObjectSearcher("select * from Win32_Process WHERE Name = 'dotnet.exe'"))
            {
                return (from item in searcher.Get().Cast<ManagementObject>()
                        select new Win32Process()
                        {
                            Caption = System.Convert.ToString(item.Properties["Caption"].Value),
                            CommandLine = System.Convert.ToString(item.Properties["CommandLine"].Value),
                            CreationClassName = System.Convert.ToString(item.Properties["CreationClassName"].Value),
                            CreationDate = ManagementUtils.ToDateTime(item.Properties["CreationDate"].Value),
                            CSCreationClassName = System.Convert.ToString(item.Properties["CSCreationClassName"].Value),
                            CSName = System.Convert.ToString(item.Properties["CSName"].Value),
                            Description = System.Convert.ToString(item.Properties["Description"].Value),
                            ExecutablePath = System.Convert.ToString(item.Properties["ExecutablePath"].Value),
                            ExecutionState = (UInt16?)item.Properties["ExecutionState"].Value,
                            Handle = System.Convert.ToString(item.Properties["Handle"].Value),
                            HandleCount = (UInt32?)item.Properties["HandleCount"].Value,
                            InstallDate = ManagementUtils.ToDateTime(item.Properties["InstallDate"].Value),
                            KernelModeTime = (UInt64?)item.Properties["KernelModeTime"].Value,
                            MaximumWorkingSetSize = (UInt32?)item.Properties["MaximumWorkingSetSize"].Value,
                            MinimumWorkingSetSize = (UInt32?)item.Properties["MinimumWorkingSetSize"].Value,
                            Name = System.Convert.ToString(item.Properties["Name"].Value),
                            OSCreationClassName = System.Convert.ToString(item.Properties["OSCreationClassName"].Value),
                            OSName = System.Convert.ToString(item.Properties["OSName"].Value),
                            OtherOperationCount = (UInt64?)item.Properties["OtherOperationCount"].Value,
                            OtherTransferCount = (UInt64?)item.Properties["OtherTransferCount"].Value,
                            PageFaults = (UInt32?)item.Properties["PageFaults"].Value,
                            PageFileUsage = (UInt32?)item.Properties["PageFileUsage"].Value,
                            ParentProcessId = (UInt32?)item.Properties["ParentProcessId"].Value,
                            PeakPageFileUsage = (UInt32?)item.Properties["PeakPageFileUsage"].Value,
                            PeakVirtualSize = (UInt64?)item.Properties["PeakVirtualSize"].Value,
                            PeakWorkingSetSize = (UInt32?)item.Properties["PeakWorkingSetSize"].Value,
                            Priority = (UInt32?)item.Properties["Priority"].Value,
                            PrivatePageCount = (UInt64?)item.Properties["PrivatePageCount"].Value,
                            ProcessId = (UInt32?)item.Properties["ProcessId"].Value,
                            QuotaNonPagedPoolUsage = (UInt32?)item.Properties["QuotaNonPagedPoolUsage"].Value,
                            QuotaPagedPoolUsage = (UInt32?)item.Properties["QuotaPagedPoolUsage"].Value,
                            QuotaPeakNonPagedPoolUsage = (UInt32?)item.Properties["QuotaPeakNonPagedPoolUsage"].Value,
                            QuotaPeakPagedPoolUsage = (UInt32?)item.Properties["QuotaPeakPagedPoolUsage"].Value,
                            ReadOperationCount = (UInt64?)item.Properties["ReadOperationCount"].Value,
                            ReadTransferCount = (UInt64?)item.Properties["ReadTransferCount"].Value,
                            SessionId = (UInt32?)item.Properties["SessionId"].Value,
                            Status = System.Convert.ToString(item.Properties["Status"].Value),
                            TerminationDate = ManagementUtils.ToDateTime(item.Properties["TerminationDate"].Value),
                            ThreadCount = (UInt32?)item.Properties["ThreadCount"].Value,
                            UserModeTime = (UInt64?)item.Properties["UserModeTime"].Value,
                            VirtualSize = (UInt64?)item.Properties["VirtualSize"].Value,
                            WindowsVersion = System.Convert.ToString(item.Properties["WindowsVersion"].Value),
                            WorkingSetSize = (UInt64?)item.Properties["WorkingSetSize"].Value,
                            WriteOperationCount = (UInt64?)item.Properties["WriteOperationCount"].Value,
                            WriteTransferCount = (UInt64?)item.Properties["WriteTransferCount"].Value
                        }).ToArray();
            }
        }
    }

    internal class ManagementUtils
    {
        internal static DateTime? ToDateTime(object value)
        {
            if (value == null)
            {
                return null;
            }

            return ManagementDateTimeConverter.ToDateTime(Convert.ToString(value));
        }
    }
}
