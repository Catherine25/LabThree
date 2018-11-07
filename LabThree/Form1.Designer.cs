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
            this.dataGridView1.Location = new System.Drawing.Point(16, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(765, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxComputers
            // 
            this.comboBoxComputers.FormattingEnabled = true;
            this.comboBoxComputers.Location = new System.Drawing.Point(128, 8);
            this.comboBoxComputers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxComputers.Name = "comboBoxComputers";
            this.comboBoxComputers.Size = new System.Drawing.Size(288, 28);
            this.comboBoxComputers.TabIndex = 1;
            this.comboBoxComputers.SelectedIndexChanged += new System.EventHandler(this.ComboBoxComputers_SelectedIndexChanged);
            // 
            // buttonEditComputer
            // 
            this.buttonEditComputer.Location = new System.Drawing.Point(426, 5);
            this.buttonEditComputer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEditComputer.Name = "buttonEditComputer";
            this.buttonEditComputer.Size = new System.Drawing.Size(112, 35);
            this.buttonEditComputer.TabIndex = 2;
            this.buttonEditComputer.Text = "Edit";
            this.buttonEditComputer.UseVisualStyleBackColor = true;
            this.buttonEditComputer.Click += new System.EventHandler(this.ButtonEditComputer_Click);
            // 
            // buttonDeleteComputer
            // 
            this.buttonDeleteComputer.Location = new System.Drawing.Point(669, 5);
            this.buttonDeleteComputer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteComputer.Name = "buttonDeleteComputer";
            this.buttonDeleteComputer.Size = new System.Drawing.Size(112, 35);
            this.buttonDeleteComputer.TabIndex = 3;
            this.buttonDeleteComputer.Text = "Delete";
            this.buttonDeleteComputer.UseVisualStyleBackColor = true;
            this.buttonDeleteComputer.Click += new System.EventHandler(this.ButtonDeleteComputer_Click);
            // 
            // buttonAddComputer
            // 
            this.buttonAddComputer.Location = new System.Drawing.Point(548, 5);
            this.buttonAddComputer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddComputer.Name = "buttonAddComputer";
            this.buttonAddComputer.Size = new System.Drawing.Size(112, 35);
            this.buttonAddComputer.TabIndex = 4;
            this.buttonAddComputer.Text = "Add";
            this.buttonAddComputer.UseVisualStyleBackColor = true;
            this.buttonAddComputer.Click += new System.EventHandler(this.ButtonAddComputer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Computers";
            // 
            // buttonAddProcess
            // 
            this.buttonAddProcess.Location = new System.Drawing.Point(16, 380);
            this.buttonAddProcess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddProcess.Name = "buttonAddProcess";
            this.buttonAddProcess.Size = new System.Drawing.Size(170, 35);
            this.buttonAddProcess.TabIndex = 6;
            this.buttonAddProcess.Text = "Add process";
            this.buttonAddProcess.UseVisualStyleBackColor = true;
            this.buttonAddProcess.Click += new System.EventHandler(this.ButtonAddProcess_Click);
            // 
            // buttonDeleteProcess
            // 
            this.buttonDeleteProcess.Location = new System.Drawing.Point(195, 380);
            this.buttonDeleteProcess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteProcess.Name = "buttonDeleteProcess";
            this.buttonDeleteProcess.Size = new System.Drawing.Size(164, 35);
            this.buttonDeleteProcess.TabIndex = 7;
            this.buttonDeleteProcess.Text = "Delete process";
            this.buttonDeleteProcess.UseVisualStyleBackColor = true;
            this.buttonDeleteProcess.Click += new System.EventHandler(this.ButtonDeleteProcess_Click);
            // 
            // buttonEditProcess
            // 
            this.buttonEditProcess.Location = new System.Drawing.Point(608, 380);
            this.buttonEditProcess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEditProcess.Name = "buttonEditProcess";
            this.buttonEditProcess.Size = new System.Drawing.Size(174, 35);
            this.buttonEditProcess.TabIndex = 8;
            this.buttonEditProcess.Text = "Change process";
            this.buttonEditProcess.UseVisualStyleBackColor = true;
            this.buttonEditProcess.Click += new System.EventHandler(this.ButtonEditProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
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

