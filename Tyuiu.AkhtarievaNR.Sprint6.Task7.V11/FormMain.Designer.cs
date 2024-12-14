namespace Tyuiu.AkhtarievaNR.Sprint6.Task7.V11
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonAbout_ANR = new Button();
            buttonSaveFile_ANR = new Button();
            buttonDone_ANR = new Button();
            buttonAddFile_ANR = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            dataGridViewInPut_ANR = new DataGridView();
            panel5 = new Panel();
            groupBox3 = new GroupBox();
            dataGridViewOutPut_ANR = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogTask = new SaveFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_ANR).BeginInit();
            panel5.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_ANR).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonAbout_ANR);
            panel1.Controls.Add(buttonSaveFile_ANR);
            panel1.Controls.Add(buttonDone_ANR);
            panel1.Controls.Add(buttonAddFile_ANR);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 64);
            panel1.TabIndex = 0;
            // 
            // buttonAbout_ANR
            // 
            buttonAbout_ANR.Image = (Image)resources.GetObject("buttonAbout_ANR.Image");
            buttonAbout_ANR.Location = new Point(826, 3);
            buttonAbout_ANR.Name = "buttonAbout_ANR";
            buttonAbout_ANR.Size = new Size(63, 58);
            buttonAbout_ANR.TabIndex = 2;
            buttonAbout_ANR.UseVisualStyleBackColor = true;
            buttonAbout_ANR.Click += buttonAbout_ANR_Click;
            // 
            // buttonSaveFile_ANR
            // 
            buttonSaveFile_ANR.Image = (Image)resources.GetObject("buttonSaveFile_ANR.Image");
            buttonSaveFile_ANR.Location = new Point(168, 3);
            buttonSaveFile_ANR.Name = "buttonSaveFile_ANR";
            buttonSaveFile_ANR.Size = new Size(84, 60);
            buttonSaveFile_ANR.TabIndex = 1;
            buttonSaveFile_ANR.UseVisualStyleBackColor = true;
            buttonSaveFile_ANR.Click += buttonSafeFile_ANR_Click;
            // 
            // buttonDone_ANR
            // 
            buttonDone_ANR.Image = (Image)resources.GetObject("buttonDone_ANR.Image");
            buttonDone_ANR.Location = new Point(84, 3);
            buttonDone_ANR.Name = "buttonDone_ANR";
            buttonDone_ANR.Size = new Size(78, 60);
            buttonDone_ANR.TabIndex = 1;
            buttonDone_ANR.UseVisualStyleBackColor = true;
            buttonDone_ANR.Click += buttonDone_ANR_Click;
            // 
            // buttonAddFile_ANR
            // 
            buttonAddFile_ANR.Image = (Image)resources.GetObject("buttonAddFile_ANR.Image");
            buttonAddFile_ANR.Location = new Point(3, 3);
            buttonAddFile_ANR.Name = "buttonAddFile_ANR";
            buttonAddFile_ANR.Size = new Size(75, 60);
            buttonAddFile_ANR.TabIndex = 1;
            buttonAddFile_ANR.UseVisualStyleBackColor = true;
            buttonAddFile_ANR.Click += buttonAddFile_ANR_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(2, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 94);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(897, 94);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(3, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(886, 68);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Location = new Point(2, 169);
            panel3.Name = "panel3";
            panel3.Size = new Size(458, 305);
            panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewInPut_ANR);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(458, 305);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод:";
            // 
            // dataGridViewInPut_ANR
            // 
            dataGridViewInPut_ANR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut_ANR.ColumnHeadersVisible = false;
            dataGridViewInPut_ANR.Location = new Point(10, 25);
            dataGridViewInPut_ANR.Name = "dataGridViewInPut_ANR";
            dataGridViewInPut_ANR.RowHeadersVisible = false;
            dataGridViewInPut_ANR.RowHeadersWidth = 51;
            dataGridViewInPut_ANR.Size = new Size(454, 262);
            dataGridViewInPut_ANR.TabIndex = 0;
            dataGridViewInPut_ANR.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel5
            // 
            panel5.Controls.Add(groupBox3);
            panel5.Location = new Point(466, 169);
            panel5.Name = "panel5";
            panel5.Size = new Size(433, 305);
            panel5.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewOutPut_ANR);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(433, 305);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод:";
            // 
            // dataGridViewOutPut_ANR
            // 
            dataGridViewOutPut_ANR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_ANR.ColumnHeadersVisible = false;
            dataGridViewOutPut_ANR.Location = new Point(6, 29);
            dataGridViewOutPut_ANR.Name = "dataGridViewOutPut_ANR";
            dataGridViewOutPut_ANR.RowHeadersVisible = false;
            dataGridViewOutPut_ANR.RowHeadersWidth = 51;
            dataGridViewOutPut_ANR.Size = new Size(417, 262);
            dataGridViewOutPut_ANR.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 478);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 11 | Ахтариева Н. Р.";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_ANR).EndInit();
            panel5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_ANR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonSaveFile_ANR;
        private Button buttonDone_ANR;
        private Button buttonAddFile_ANR;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Panel panel3;
        private Panel panel5;
        private GroupBox groupBox2;
        private DataGridView dataGridViewInPut_ANR;
        private GroupBox groupBox3;
        private DataGridView dataGridViewOutPut_ANR;
        private Button buttonAbout_ANR;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogTask;
    }
}
