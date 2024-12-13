namespace Tyuiu.AkhtarievaNR.Sprint6.Task5.V23
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            buttonHelp_ANR = new Button();
            buttonOpenFile_ANR = new Button();
            buttonDone_ANR = new Button();
            dataGridViewDone_ANR = new DataGridView();
            groupBox3 = new GroupBox();
            chartfunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDone_ANR).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartfunction).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(13, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 123);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(16, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(471, 75);
            textBox1.TabIndex = 2;
            textBox1.Text = "Прочитать данные из файла InPutDataFileTask5V23.txt. Вывести отрицательные значения и построить диаграмму по этим значениям.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonHelp_ANR);
            groupBox2.Controls.Add(buttonOpenFile_ANR);
            groupBox2.Controls.Add(buttonDone_ANR);
            groupBox2.Location = new Point(542, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 123);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // buttonHelp_ANR
            // 
            buttonHelp_ANR.Location = new Point(342, 27);
            buttonHelp_ANR.Name = "buttonHelp_ANR";
            buttonHelp_ANR.Size = new Size(107, 76);
            buttonHelp_ANR.TabIndex = 2;
            buttonHelp_ANR.Text = "Справка";
            buttonHelp_ANR.UseVisualStyleBackColor = true;
            buttonHelp_ANR.Click += buttonHelp_ANR_Click;
            // 
            // buttonOpenFile_ANR
            // 
            buttonOpenFile_ANR.Location = new Point(185, 26);
            buttonOpenFile_ANR.Name = "buttonOpenFile_ANR";
            buttonOpenFile_ANR.Size = new Size(134, 77);
            buttonOpenFile_ANR.TabIndex = 1;
            buttonOpenFile_ANR.Text = "Открыть файл";
            buttonOpenFile_ANR.UseVisualStyleBackColor = true;
            buttonOpenFile_ANR.Click += buttonOpenFile_ANR_Click;
            // 
            // buttonDone_ANR
            // 
            buttonDone_ANR.Location = new Point(23, 26);
            buttonDone_ANR.Name = "buttonDone_ANR";
            buttonDone_ANR.Size = new Size(139, 77);
            buttonDone_ANR.TabIndex = 0;
            buttonDone_ANR.Text = "Выполнить";
            buttonDone_ANR.UseVisualStyleBackColor = true;
            buttonDone_ANR.Click += buttonDone_ANR_Click;
            // 
            // dataGridViewDone_ANR
            // 
            dataGridViewDone_ANR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDone_ANR.ColumnHeadersVisible = false;
            dataGridViewDone_ANR.Location = new Point(0, 26);
            dataGridViewDone_ANR.Name = "dataGridViewDone_ANR";
            dataGridViewDone_ANR.RowHeadersVisible = false;
            dataGridViewDone_ANR.RowHeadersWidth = 51;
            dataGridViewDone_ANR.Size = new Size(190, 309);
            dataGridViewDone_ANR.TabIndex = 2;
            //dataGridViewDone_ANR.CellContentClick += dataGridViewDone_ANR_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewDone_ANR);
            groupBox3.Location = new Point(12, 130);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(190, 335);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных:";
            // 
            // chartfunction
            // 
            chartArea1.Name = "ChartArea1";
            chartfunction.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartfunction.Legends.Add(legend1);
            chartfunction.Location = new Point(208, 148);
            chartfunction.Name = "chartfunction";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartfunction.Series.Add(series1);
            chartfunction.Size = new Size(800, 317);
            chartfunction.TabIndex = 4;
            chartfunction.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 477);
            Controls.Add(chartfunction);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 23 | Ахтариева Н. Р.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDone_ANR).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartfunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Button buttonHelp_ANR;
        private Button buttonOpenFile_ANR;
        private Button buttonDone_ANR;
        private DataGridView dataGridViewDone_ANR;
        private GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartfunction;
    }
}
