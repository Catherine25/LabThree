using System;

namespace LabThree.Data {
    public static class Controller {
        public static void CheckString(string s) {
            if (s == null || s == "" || s == " ")
                throw new Exception();
        }
        public static void CheckDoubleIsNegativeOrNull(double d) {
            if (d <= 0)
                throw new Exception();
        }
        public static void CheckPriority(int p) {
            if (p < 0 || p > 4)
                throw new Exception();
        }
        public static void CheckIntIsNegativeOrNull(int i) {
            if (i < 0 || i == 0)
                throw new Exception();
        }
    }
}
