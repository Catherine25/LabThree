using System;
using System.Windows.Forms;

namespace LabThree
{
    public partial class dialogForm : Form
    {
        private MyDelegate d;
        public dialogForm(string label, MyDelegate my)
        {
            InitializeComponent();
            MainLabel.Text = label;
            d = my;
        }
        private void ButtonCancel_Click(object sender, EventArgs e) => ActiveForm.Close();
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            int ram, cpuCount;
            double cpuFreq;         
            if(int.TryParse(textBoxRam.Text, out ram))
            {
                if (int.TryParse(textBoxCPUCount.Text, out cpuCount))
                    if (double.TryParse(textBoxCPUCount.Text, out cpuFreq))
                        if (Data.Controller.CheckComputer(textBoxName.Text, ram, cpuFreq, cpuCount))
                        {
                            d(textBoxName.Text, ram, cpuFreq, cpuCount);
                            MessageBox.Show("Operation completed!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
            }
            else
                MessageBox.Show("Operation failed!", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }
    }
}
