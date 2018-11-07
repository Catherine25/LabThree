using System;
using System.Windows.Forms;

namespace LabThree
{
    public partial class dialogForProcess : Form
    {
        private MyDelegateProcess d;
        public dialogForProcess(string label, MyDelegateProcess my)
        {
            InitializeComponent();
            MainLabel.Text = label;
            d = my;
        }
        private void ButtonCancel_Click(object sender, EventArgs e) => Close();
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            //checking if conversation is possible
            double cpu, ram;
            int priority;
            if (double.TryParse(textBoxCPU.Text.ToString(), out cpu))
            {
                if (double.TryParse(textBoxRAM.Text.ToString(), out ram))
                    if (int.TryParse(textBoxPriority.Text.ToString(), out priority))
                        if (Data.Controller.CheckProcess(textBoxName.Text, textBoxUser.Text, textBoxPath.Text,
                            textBoxInfo.Text, cpu, ram, priority))
                        {
                            d(textBoxName.Text, textBoxUser.Text, cpu, ram, textBoxPath.Text, textBoxInfo.Text, priority);
                            MessageBox.Show("Operation completed!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
            }
            else
                MessageBox.Show("Operation failed!", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }
    }
}
