namespace LabThree
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxComputers = new System.Windows.Forms.ComboBox();
            this.buttonEditComputer = new System.Windows.Forms.Button();
            this.buttonDeleteComputer = new System.Windows.Forms.Button();
            this.buttonAddComputer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddProcess = new System.Windows.Forms.Button();
            this.buttonDeleteProcess = new System.Windows.Forms.Button();
            this.buttonEditProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(510, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxComputers
            // 
            this.comboBoxComputers.FormattingEnabled = true;
            this.comboBoxComputers.Location = new System.Drawing.Point(85, 5);
            this.comboBoxComputers.Name = "comboBoxComputers";
            this.comboBoxComputers.Size = new System.Drawing.Size(193, 21);
            this.comboBoxComputers.TabIndex = 1;
            this.comboBoxComputers.SelectedIndexChanged += new System.EventHandler(this.ComboBoxComputers_SelectedIndexChanged);
            // 
            // buttonEditComputer
            // 
            this.buttonEditComputer.Location = new System.Drawing.Point(284, 3);
            this.buttonEditComputer.Name = "buttonEditComputer";
            this.buttonEditComputer.Size = new System.Drawing.Size(75, 23);
            this.buttonEditComputer.TabIndex = 2;
            this.buttonEditComputer.Text = "Изменить";
            this.buttonEditComputer.UseVisualStyleBackColor = true;
            this.buttonEditComputer.Click += new System.EventHandler(this.ButtonEditComputer_Click);
            // 
            // buttonDeleteComputer
            // 
            this.buttonDeleteComputer.Location = new System.Drawing.Point(446, 3);
            this.buttonDeleteComputer.Name = "buttonDeleteComputer";
            this.buttonDeleteComputer.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteComputer.TabIndex = 3;
            this.buttonDeleteComputer.Text = "Удалить";
            this.buttonDeleteComputer.UseVisualStyleBackColor = true;
            this.buttonDeleteComputer.Click += new System.EventHandler(this.ButtonDeleteComputer_Click);
            // 
            // buttonAddComputer
            // 
            this.buttonAddComputer.Location = new System.Drawing.Point(365, 3);
            this.buttonAddComputer.Name = "buttonAddComputer";
            this.buttonAddComputer.Size = new System.Drawing.Size(75, 23);
            this.buttonAddComputer.TabIndex = 4;
            this.buttonAddComputer.Text = "Добавить";
            this.buttonAddComputer.UseVisualStyleBackColor = true;
            this.buttonAddComputer.Click += new System.EventHandler(this.ButtonAddComputer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Компютеры";
            // 
            // buttonAddProcess
            // 
            this.buttonAddProcess.Location = new System.Drawing.Point(11, 247);
            this.buttonAddProcess.Name = "buttonAddProcess";
            this.buttonAddProcess.Size = new System.Drawing.Size(113, 23);
            this.buttonAddProcess.TabIndex = 6;
            this.buttonAddProcess.Text = "Добавить процесс";
            this.buttonAddProcess.UseVisualStyleBackColor = true;
            this.buttonAddProcess.Click += new System.EventHandler(this.ButtonAddProcess_Click);
            // 
            // buttonDeleteProcess
            // 
            this.buttonDeleteProcess.Location = new System.Drawing.Point(130, 247);
            this.buttonDeleteProcess.Name = "buttonDeleteProcess";
            this.buttonDeleteProcess.Size = new System.Drawing.Size(109, 23);
            this.buttonDeleteProcess.TabIndex = 7;
            this.buttonDeleteProcess.Text = "Удалить процесс";
            this.buttonDeleteProcess.UseVisualStyleBackColor = true;
            this.buttonDeleteProcess.Click += new System.EventHandler(this.ButtonDeleteProcess_Click);
            // 
            // buttonEditProcess
            // 
            this.buttonEditProcess.Location = new System.Drawing.Point(405, 247);
            this.buttonEditProcess.Name = "buttonEditProcess";
            this.buttonEditProcess.Size = new System.Drawing.Size(116, 23);
            this.buttonEditProcess.TabIndex = 8;
            this.buttonEditProcess.Text = "Изменить процесс";
            this.buttonEditProcess.UseVisualStyleBackColor = true;
            this.buttonEditProcess.Click += new System.EventHandler(this.ButtonEditProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 278);
            this.Controls.Add(this.buttonEditProcess);
            this.Controls.Add(this.buttonDeleteProcess);
            this.Controls.Add(this.buttonAddProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddComputer);
            this.Controls.Add(this.buttonDeleteComputer);
            this.Controls.Add(this.buttonEditComputer);
            this.Controls.Add(this.comboBoxComputers);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Диспетчер процессов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxComputers;
        private System.Windows.Forms.Button buttonEditComputer;
        private System.Windows.Forms.Button buttonDeleteComputer;
        private System.Windows.Forms.Button buttonAddComputer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddProcess;
        private System.Windows.Forms.Button buttonDeleteProcess;
        private System.Windows.Forms.Button buttonEditProcess;
    }
}

