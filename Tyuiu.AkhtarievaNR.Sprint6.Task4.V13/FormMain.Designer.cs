namespace Tyuiu.AkhtarievaNR.Sprint6.Task4.V13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            buttonHelp_ANR = new Button();
            buttonSave_ANR = new Button();
            buttonDone_ANR = new Button();
            textBoxStop_ANR = new TextBox();
            textBoxStart_ANR = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            groupBox3 = new GroupBox();
            textBoxDone_ANR = new TextBox();
            chartfunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartfunction).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 35);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(467, 72);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести, построить график функции и сохранить в файл по нажатию кнопки.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonHelp_ANR);
            groupBox2.Controls.Add(buttonSave_ANR);
            groupBox2.Controls.Add(buttonDone_ANR);
            groupBox2.Controls.Add(textBoxStop_ANR);
            groupBox2.Controls.Add(textBoxStart_ANR);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(521, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(669, 113);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных:";
            // 
            // buttonHelp_ANR
            // 
            buttonHelp_ANR.Location = new Point(554, 26);
            buttonHelp_ANR.Name = "buttonHelp_ANR";
            buttonHelp_ANR.Size = new Size(97, 69);
            buttonHelp_ANR.TabIndex = 6;
            buttonHelp_ANR.Text = "Справка";
            buttonHelp_ANR.UseVisualStyleBackColor = true;
            // 
            // buttonSave_ANR
            // 
            buttonSave_ANR.Location = new Point(438, 26);
            buttonSave_ANR.Name = "buttonSave_ANR";
            buttonSave_ANR.Size = new Size(97, 69);
            buttonSave_ANR.TabIndex = 5;
            buttonSave_ANR.Text = "Сохранить";
            buttonSave_ANR.UseVisualStyleBackColor = true;
            // 
            // buttonDone_ANR
            // 
            buttonDone_ANR.Location = new Point(299, 26);
            buttonDone_ANR.Name = "buttonDone_ANR";
            buttonDone_ANR.Size = new Size(121, 69);
            buttonDone_ANR.TabIndex = 4;
            buttonDone_ANR.Text = "Выполнить";
            buttonDone_ANR.UseVisualStyleBackColor = true;
            buttonDone_ANR.Click += buttonDone_ANR_Click;
            // 
            // textBoxStop_ANR
            // 
            textBoxStop_ANR.Location = new Point(149, 68);
            textBoxStop_ANR.Name = "textBoxStop_ANR";
            textBoxStop_ANR.Size = new Size(132, 27);
            textBoxStop_ANR.TabIndex = 3;
            // 
            // textBoxStart_ANR
            // 
            textBoxStart_ANR.Location = new Point(6, 68);
            textBoxStart_ANR.Name = "textBoxStart_ANR";
            textBoxStart_ANR.Size = new Size(137, 27);
            textBoxStart_ANR.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuBar;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(149, 35);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 20);
            textBox3.TabIndex = 1;
            textBox3.Text = "Конец шага:";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(6, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 20);
            textBox2.TabIndex = 0;
            textBox2.Text = "Старт шага:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxDone_ANR);
            groupBox3.Location = new Point(12, 131);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(296, 376);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод:";
            // 
            // textBoxDone_ANR
            // 
            textBoxDone_ANR.Location = new Point(6, 26);
            textBoxDone_ANR.Multiline = true;
            textBoxDone_ANR.Name = "textBoxDone_ANR";
            textBoxDone_ANR.ScrollBars = ScrollBars.Vertical;
            textBoxDone_ANR.Size = new Size(284, 341);
            textBoxDone_ANR.TabIndex = 1;
            // 
            // chartfunction
            // 
            chartArea2.Name = "ChartArea1";
            chartfunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartfunction.Legends.Add(legend2);
            chartfunction.Location = new Point(324, 131);
            chartfunction.Name = "chartfunction";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartfunction.Series.Add(series2);
            chartfunction.Size = new Size(866, 367);
            chartfunction.TabIndex = 3;
            chartfunction.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 519);
            Controls.Add(chartfunction);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 18 | Ахтариева Н. Р.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartfunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button buttonHelp_ANR;
        private Button buttonSave_ANR;
        private Button buttonDone_ANR;
        private TextBox textBoxStop_ANR;
        private TextBox textBoxStart_ANR;
        private TextBox textBox3;
        private TextBox textBox2;
        private GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartfunction;
        private TextBox textBoxDone_ANR;
    }
}
