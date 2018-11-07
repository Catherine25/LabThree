namespace LabThree
{
    public class Process
    {
        public string Name { get; set; }
        public string User { get; set; }
        public double CPU { get; set; }
        public double Mem { get; set; }
        public string Path { get; set; }
        public string Info { get; set; }
        public int Priority { get; set; }
        //constructors
        public Process(string name, string user, double cpu, double mem, string path,
            string info, int priority)
        {
            Name = name;
            User = user;
            CPU = cpu;
            Mem = mem;
            Path = path;
            Info = info;
            Priority = priority;
        }
        void Copy (Process process)
        {
            Name = process.Name;
            User = process.User;
            CPU = process.CPU;
            Mem = process.Mem;
            Path = process.Path;
            Info = process.Info;
            Priority = process.Priority;
        }
        public static Process operator +(Process p1, Process p2) => new Process(p1.Name + ", " + p2.Name,
                p1.User + ", " + p2.User,
                p1.CPU + p2.CPU,
                p1.Mem + p2.Mem,
                p1.Path + ", " + p2.Path,
                p1.Info + ", " + p2.Info,
                p1.Priority + p2.Priority);
    }
}
