using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThree
{
    class Computer
    {
        public string Name { get; set; }
        public int RAM { get; set; }
        //process List
        private List<Process> processes = new List<Process>();
        public double CPUFrequency { get; set; }
        public int CPUCount { get; set; }

        public void ChangeRAM(int value)
        {
            RAM += value;
        }
        public void ChangeFrequency(int value)
        {
            CPUFrequency += value;
        }
        public void AddProcess(Process process)
        {
            processes.Add(process);
        }
        public void RemoveProcess(Process process)
        {
            processes.Remove(process);
        }
    }
}
