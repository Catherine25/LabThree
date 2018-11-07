using System;
using System.Windows.Forms;

namespace LabThree
{
    public partial class Form1 : Form
    {
        ComputerManager manager = new ComputerManager("KATIA", "LOVE");
        //initializing
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }
        void InitializeComboBox()
        {
            var keys = manager.GetComputersHashtableKeys();
            comboBoxComputers.Items.Clear();
            foreach (object key in keys)
                comboBoxComputers.Items.Add(manager.GetComputersHashtableByIndex(key));
            if (comboBoxComputers.Items.Count != 0)
                comboBoxComputers.SelectedIndex = 0;
        }
        void InitializeDataGrid(Computer selectedComputer)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = selectedComputer.GetProcessesRange(0, selectedComputer.GetProcessesCount());
            dataGridView1.Columns["Name"].HeaderText = "PROCESS";
            dataGridView1.Columns["Priority"].DisplayIndex = 1;
            dataGridView1.Columns["Priority"].HeaderText = "PRIORITY";
            dataGridView1.Columns["CPU"].DisplayIndex = 2;
            dataGridView1.Columns["CPU"].HeaderText = "CPU";
            dataGridView1.Columns["Mem"].DisplayIndex = 3;
            dataGridView1.Columns["Mem"].HeaderText = "MEMORY";
            dataGridView1.Columns["Info"].DisplayIndex = 4;
            dataGridView1.Columns["Info"].HeaderText = "INFO";
            dataGridView1.Columns["User"].Visible = false;
            dataGridView1.Columns["Path"].Visible = false;
        }
        //Form1 UI
        private void ComboBoxComputers_SelectedIndexChanged(object sender, EventArgs e) => InitializeDataGrid((Computer)comboBoxComputers.SelectedItem);
        private void ButtonAddComputer_Click(object sender, EventArgs e)
        {
            dialogForm dialog = new dialogForm("Adding new computer", new MyDelegate(FuncForAdd));
            dialog.ShowDialog();
            InitializeComboBox();
        }
        private void ButtonEditComputer_Click(object sender, EventArgs e)
        {
            var selectComputer = (Computer)comboBoxComputers.SelectedItem;
            if (selectComputer != null)
            {
                dialogForm dialog = new dialogForm("Computer settings", new MyDelegate(FuncForEdit));
                dialog.textBoxName.Text = selectComputer.Name;
                dialog.textBoxRam.Text = selectComputer.RAM.ToString();
                dialog.textBoxCPUFreq.Text = selectComputer.CPUFrequency.ToString();
                dialog.textBoxCPUCount.Text = selectComputer.CPUCount.ToString();
                dialog.ShowDialog();
                InitializeComboBox();
            }
            else
                MessageBox.Show("No computers to edit!", "Operation failed!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void ButtonDeleteComputer_Click(object sender, EventArgs e)
        {
            Computer selectComputer = (Computer)comboBoxComputers.SelectedItem;
            if (selectComputer != null)
            {
                if (MessageBox.Show("Are you sure to delete computer? " + selectComputer.Name, "Delete computer",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    manager.RemoveComputer(selectComputer);
                    InitializeComboBox();
                }
            }
            else
                MessageBox.Show("No computers to delete!", "Operation failed!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void ButtonAddProcess_Click(object sender, EventArgs e)
        {
            var selectComputer = (Computer)comboBoxComputers.SelectedItem;
            if (selectComputer != null)
            {
                dialogForProcess dialog = new dialogForProcess("Adding new process", new MyDelegateProcess(FuncForAddProcess));
                dialog.ShowDialog();
                InitializeComboBox();
                InitializeDataGrid(selectComputer);
            }
            else
                MessageBox.Show("No computers to add to!", "Operation failed!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void ButtonEditProcess_Click(object sender, EventArgs e)
        {
            var selectComputer = (Computer)comboBoxComputers.SelectedItem;
            if (selectComputer != null)
            {
                var selectProcess = selectComputer.GetProcessByIndex(dataGridView1.CurrentRow.Index);
                dialogForProcess dialog = new dialogForProcess("Adding new process", new MyDelegateProcess(FuncForEditProcess));
                dialog.textBoxName.Text = selectProcess.Name;
                dialog.textBoxUser.Text = selectProcess.User;
                dialog.textBoxCPU.Text = selectProcess.CPU.ToString();
                dialog.textBoxRAM.Text = selectProcess.Mem.ToString();
                dialog.textBoxPath.Text = selectProcess.Path;
                dialog.textBoxInfo.Text = selectProcess.Info;
                dialog.textBoxPriority.Text = selectProcess.Priority.ToString();
                dialog.ShowDialog();
                InitializeDataGrid(selectComputer);
            }
            else
                MessageBox.Show("No processes to edit!", "Operation failed!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void ButtonDeleteProcess_Click(object sender, EventArgs e)
        {
            var selectComputer = (Computer)comboBoxComputers.SelectedItem;
            if (selectComputer != null)
            {
                var selectProcess = selectComputer.GetProcessByIndex(dataGridView1.CurrentRow.Index);
                if (MessageBox.Show("Are you sure to delete process? " + selectProcess.Name,
                    "Delete process", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    manager.RemoveProcessFromComputer(selectProcess, selectComputer);
                    InitializeDataGrid(selectComputer);
                }
            }
            else
                MessageBox.Show("No processes to delete!", "Operation failed!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //delegated functions
        public void FuncForAdd(string name, int ram, double cpuFreq, int cpuCount) =>
            manager.AddComputer(new Computer(name, ram, cpuFreq, cpuCount));
        public void FuncForEdit(string name, int ram, double cpuFreq, int cpuCount)
        {
            Computer selectComputer = (Computer)comboBoxComputers.SelectedItem;
            manager.ChangeComputerName(selectComputer, name);
            manager.ChangeComputerRAM(selectComputer, ram);
            manager.ChangeComputerCPUFrequency(selectComputer, cpuFreq);
            manager.ChangeComputerCPUCount(selectComputer, cpuCount);
        }
        public void FuncForAddProcess(string name, string user, double cpu, double mem, string path, string info, int priority)
        {
            Computer selectComputer = (Computer)comboBoxComputers.SelectedItem;
            selectComputer.AddProcess(new Process(name, user, cpu, mem, path, info, priority));
        }
        public void FuncForEditProcess(string name, string user, double cpu, double ram, string path, string info, int priority)
        {
            var selectComputer = (Computer)comboBoxComputers.SelectedItem;
            var selectProcess = selectComputer.GetProcessByIndex(dataGridView1.CurrentRow.Index);
            manager.ChangeProcessName(selectProcess, name);
            manager.ChangeProcessUser(selectProcess, user);
            manager.ChangeProcessCPU(selectProcess, cpu);
            manager.ChangeProcessMem(selectProcess, ram);
            manager.ChangeProcessPath(selectProcess, path);
            manager.ChangeProcessInfo(selectProcess, info);
            manager.ChangeProcessPriority(selectProcess, priority);
        }     
    }
}
