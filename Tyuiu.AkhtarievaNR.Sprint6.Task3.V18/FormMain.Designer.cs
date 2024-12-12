namespace Tyuiu.AkhtarievaNR.Sprint6.Task3.V18
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
            groupBoxusl_ANR = new GroupBox();
            textBox4 = new TextBox();
            dataGridViewmatrixres_ANR = new DataGridView();
            groupBoxres_ANR = new GroupBox();
            buttonDone_ANR = new Button();
            buttonHelp_ANR = new Button();
            textBox2 = new TextBox();
            dataGridViewMatrixDone_ANR = new DataGridView();
            groupBoxusl_ANR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewmatrixres_ANR).BeginInit();
            groupBoxres_ANR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixDone_ANR).BeginInit();
            SuspendLayout();
            // 
            // groupBoxusl_ANR
            // 
            groupBoxusl_ANR.Controls.Add(textBox4);
            groupBoxusl_ANR.Controls.Add(dataGridViewmatrixres_ANR);
            groupBoxusl_ANR.Location = new Point(12, 12);
            groupBoxusl_ANR.Name = "groupBoxusl_ANR";
            groupBoxusl_ANR.Size = new Size(493, 351);
            groupBoxusl_ANR.TabIndex = 0;
            groupBoxusl_ANR.TabStop = false;
            groupBoxusl_ANR.Text = "Условие";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.MenuBar;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(18, 33);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(190, 215);
            textBox4.TabIndex = 2;
            textBox4.Text = "Дана матрица 5 на 5:\r\n-19 -19 1 18 7\r\n5 3 -4 -6 -12\r\n-15 6 2 2 -14\r\n-9 -10 15 -5 -6\r\n-13 -15 -9 7 1\r\n заменить четные значения в четвертой строке на 0\r\n\r\n";
            // 
            // dataGridViewmatrixres_ANR
            // 
            dataGridViewmatrixres_ANR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewmatrixres_ANR.ColumnHeadersVisible = false;
            dataGridViewmatrixres_ANR.Location = new Point(243, 59);
            dataGridViewmatrixres_ANR.Name = "dataGridViewmatrixres_ANR";
            dataGridViewmatrixres_ANR.RowHeadersVisible = false;
            dataGridViewmatrixres_ANR.RowHeadersWidth = 51;
            dataGridViewmatrixres_ANR.Size = new Size(212, 215);
            dataGridViewmatrixres_ANR.TabIndex = 1;
            // 
            // groupBoxres_ANR
            // 
            groupBoxres_ANR.Controls.Add(dataGridViewMatrixDone_ANR);
            groupBoxres_ANR.Controls.Add(buttonDone_ANR);
            groupBoxres_ANR.Controls.Add(buttonHelp_ANR);
            groupBoxres_ANR.Controls.Add(textBox2);
            groupBoxres_ANR.Location = new Point(511, 12);
            groupBoxres_ANR.Name = "groupBoxres_ANR";
            groupBoxres_ANR.Size = new Size(311, 351);
            groupBoxres_ANR.TabIndex = 1;
            groupBoxres_ANR.TabStop = false;
            groupBoxres_ANR.Text = "Вывод данных";
            // 
            // buttonDone_ANR
            // 
            buttonDone_ANR.BackColor = Color.PaleGreen;
            buttonDone_ANR.Location = new Point(115, 290);
            buttonDone_ANR.Name = "buttonDone_ANR";
            buttonDone_ANR.Size = new Size(138, 50);
            buttonDone_ANR.TabIndex = 3;
            buttonDone_ANR.Text = "Выполнить";
            buttonDone_ANR.UseVisualStyleBackColor = false;
            buttonDone_ANR.Click += buttonDone_ANR_Click;
            // 
            // buttonHelp_ANR
            // 
            buttonHelp_ANR.BackColor = Color.PaleTurquoise;
            buttonHelp_ANR.Location = new Point(18, 290);
            buttonHelp_ANR.Name = "buttonHelp_ANR";
            buttonHelp_ANR.Size = new Size(79, 50);
            buttonHelp_ANR.TabIndex = 2;
            buttonHelp_ANR.Text = "Справка";
            buttonHelp_ANR.UseVisualStyleBackColor = false;
            buttonHelp_ANR.Click += buttonHelp_ANR_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(27, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 20);
            textBox2.TabIndex = 0;
            textBox2.Text = "Результат:";
            // 
            // dataGridViewMatrixDone_ANR
            // 
            dataGridViewMatrixDone_ANR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrixDone_ANR.ColumnHeadersVisible = false;
            dataGridViewMatrixDone_ANR.Location = new Point(29, 64);
            dataGridViewMatrixDone_ANR.Name = "dataGridViewMatrixDone_ANR";
            dataGridViewMatrixDone_ANR.RowHeadersVisible = false;
            dataGridViewMatrixDone_ANR.RowHeadersWidth = 51;
            dataGridViewMatrixDone_ANR.Size = new Size(224, 213);
            dataGridViewMatrixDone_ANR.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 378);
            Controls.Add(groupBoxres_ANR);
            Controls.Add(groupBoxusl_ANR);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 18 | Ахтариева Н. Р.";
            Load += FormMain_Load;
            groupBoxusl_ANR.ResumeLayout(false);
            groupBoxusl_ANR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewmatrixres_ANR).EndInit();
            groupBoxres_ANR.ResumeLayout(false);
            groupBoxres_ANR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixDone_ANR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxusl_ANR;
        private DataGridView dataGridViewmatrixres_ANR;
        private GroupBox groupBoxres_ANR;
        private TextBox textBox2;
        private TextBox textBox4;
        private Button buttonDone_ANR;
        private Button buttonHelp_ANR;
        private DataGridView dataGridViewMatrixDone_ANR;
    }
}
