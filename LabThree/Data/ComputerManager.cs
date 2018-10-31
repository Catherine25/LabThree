using LabThree.Data;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThree
{
    class ComputerManager
    {
        //Computer Hashtable
        private Hashtable ComputersHashtable = new Hashtable();
        //Dictionary/Hashtable Process
        //key   is name of process
        //value is process
        private Hashtable ProcessHashtable = new Hashtable();

        public string AdminName { get; set; }
        public string AdminPassword { get; set; }

        void AddComputer(Computer c)
        {
            ComputersHashtable.Add(c.Name, c);
        }

        void RemoveComputer(Computer c)
        {
            ComputersHashtable.Remove(c);
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

        void AddProcessToComputer(Process p, Computer c)
        {
            ProcessHashtable.Add(p.Name, p);
            c.AddProcess(p);
        }

        void RemoveProcessFromComputer(Process p, Computer c)
        {
            ProcessHashtable.Remove(p);
            c.RemoveProcess(p);
        }

        //Changing Process
        void ChangeProcessCPU(Process p, double nCpu)
        {
            Controller.CheckDoubleIsNegativeOrNull(nCpu);

            p.CPU = nCpu;
        }

        void ChangeProcessInfo(Process p, string nInfo)
        {
            Controller.CheckString(nInfo);

            p.Info = nInfo;
        }

        void ChangeProcessMem(Process p, double nMem)
        {
            Controller.CheckDoubleIsNegativeOrNull(nMem);

            p.Mem = nMem;
        }

        void ChangeProcessName(Process p, string nName)
        {
            Controller.CheckString(nName);

            p.Name = nName;
        }

        void ChangeProcessPath(Process p, string nPath)
        {
            Controller.CheckString(nPath);

            p.Path = nPath;
        }

        void ChangeProcessPriority(Process p, int nPriority)
        {
            Controller.CheckPriority(nPriority);

            p.Priority = nPriority;
        }

        void ChangeProcessUser(Process p, string nUser)
        {
            Controller.CheckString(nUser);

            p.User = nUser;
        }

        //ChangeComputer

        void ChangeComputerCPUCount(Computer c, int nCPUCount)
        {
            Controller.CheckIntIsNegativeOrNull(nCPUCount);

            c.CPUCount = nCPUCount;
        }

        void ChangeComputerCPUFrequency(Computer c, double nCPUFrequency)
        {
            Controller.CheckDoubleIsNegativeOrNull(nCPUFrequency);

            c.CPUFrequency = nCPUFrequency;
        }

        void ChangeComputerName(Computer c, string nName)
        {
            Controller.CheckString(nName);

            c.Name = nName;
        }

        void ChangeComputerRAM(Computer c, int nRAM)
        {
            Controller.CheckIntIsNegativeOrNull(nRAM);

            c.RAM = nRAM;
        }
    }
}
