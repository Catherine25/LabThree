namespace LabThree.Data
{
    //class for checking data
    public static class Controller
    {
        public static bool CheckString(string s)
        {
            if (s == null || s == "" || s == " ")
                return false;
            return true;
        }
        public static bool CheckDoubleIsNegativeOrNull(double d)
        {
            if (d <= 0)
                return false;
            return true;
        }
        public static bool CheckPriority(int p)
        {
            if (p < 1 || p > 4)
                return false;
            return true;
        }
        public static bool CheckIntIsNegativeOrNull(int i)
        {
            if (i < 0 || i == 0)
                return false;
            return true;
        }
        //complex functions
        public static bool CheckComputer(string name, double ram, double cpuFreq, int cpuCount)
        {
            if (CheckString(name)&& CheckDoubleIsNegativeOrNull(ram)&& CheckDoubleIsNegativeOrNull(cpuFreq)&& CheckIntIsNegativeOrNull(cpuCount))
                return true;
            return false;
        }
        public static bool CheckProcess(string name, string user, string path, string info, double cpu, double ram, int priority)
        {
            if (CheckString(name) && CheckString(user) && CheckString(path) && CheckString(info) && CheckDoubleIsNegativeOrNull(cpu) && CheckDoubleIsNegativeOrNull(ram) && CheckPriority(priority))
                return true;
            return false;
        }
    }
}
