using LabThree.Data;
using System.Collections;

namespace LabThree
{
    public class ComputerManager
    {
        //data
        private Hashtable ComputersHashtable;
        private Hashtable ProcessHashtable; //key is name of process; value is process itself
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
        //constructor
        ComputerManager()
        {
            ComputersHashtable = new Hashtable();
            ProcessHashtable = new Hashtable();
        }
        public ComputerManager(string aName, string aPass)
        {
            AdminName = aName;
            AdminPassword = aPass;
            ComputersHashtable = new Hashtable();
            ProcessHashtable = new Hashtable();
        }
        bool AdminAutentification(string name, string password)
        {
            Controller.CheckString(name);
            Controller.CheckString(password);
            if (AdminName == name)
                if (AdminPassword == password)
                    return true;
            return false;
        }
        //ComputersHashtable
        public void AddComputer(Computer c) => ComputersHashtable.Add(c.Name, c);
        public void RemoveComputer(Computer c) => ComputersHashtable.Remove(c);
        public ICollection GetComputersHashtableKeys() => ComputersHashtable.Keys;
        public object GetComputersHashtableByIndex(object index) => ComputersHashtable[index];
        //ProcessHashtable
        void AddProcessToComputer(Process p, Computer c)
        {
            ProcessHashtable.Add(p.Name, p);
            c.AddProcess(p);
        }
        public void RemoveProcessFromComputer(Process p, Computer c)
        {
            ProcessHashtable.Remove(p);
            c.RemoveProcess(p);
        }
        //change process
        public void ChangeProcessCPU(Process p, double nCpu) => p.CPU = nCpu;
        public void ChangeProcessInfo(Process p, string nInfo) => p.Info = nInfo;
        public void ChangeProcessMem(Process p, double nMem) => p.Mem = nMem;
        public void ChangeProcessName(Process p, string nName) => p.Name = nName;
        public void ChangeProcessPath(Process p, string nPath) => p.Path = nPath;
        public void ChangeProcessPriority(Process p, int nPriority) => p.Priority = nPriority;
        public void ChangeProcessUser(Process p, string nUser) => p.User = nUser;
        //change computer
        public void ChangeComputerCPUCount(Computer c, int nCPUCount) => c.CPUCount = nCPUCount;
        public void ChangeComputerCPUFrequency(Computer c, double nCPUFrequency) => c.CPUFrequency = nCPUFrequency;
        public void ChangeComputerName(Computer c, string nName) => c.Name = nName;
        public void ChangeComputerRAM(Computer c, int nRAM) => c.RAM = nRAM;
    }
}
