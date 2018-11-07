using System.Collections.Generic;

namespace LabThree
{
    public class Computer
    {
        //constructor
        public Computer() { }
        public Computer(string name, int ram, double cpuFreq, int cpuCount)
        {
            Name = name;
            RAM = ram;
            CPUFrequency = cpuFreq;
            CPUCount = cpuCount;
        }
        //process
        public void AddProcess(Process process) => processes.Add(process);
        public void RemoveProcess(Process process) => processes.Remove(process);
        public int GetProcessesCount() => processes.Count;
        public List<Process> GetProcessesRange(int index, int count) => processes.GetRange(index, count);
        public Process GetProcessByIndex(int index) => processes[index];
        //override
        public override string ToString() => Name + ": RAM: " + RAM + " CPU frequency: " + CPUFrequency + " CPU Count: " + CPUCount;//data
        public string Name { get; set; }
        public int RAM { get; set; }
        public double CPUFrequency { get; set; }
        public int CPUCount { get; set; }
        //process List
        List<Process> processes = new List<Process>();
    }
}
