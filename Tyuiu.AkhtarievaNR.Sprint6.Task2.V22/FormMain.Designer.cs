namespace Tyuiu.AkhtarievaNR.Sprint6.Task2.V22
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxUsl_ANR = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            groupBoxInput_ANR = new GroupBox();
            buttonres_ANR = new Button();
            buttonhelp_ANR = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBoxstop_ANR = new TextBox();
            textBoxstart_ANR = new TextBox();
            groupBoxOutput_ANR = new GroupBox();
            chartfunctions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewres_ANR = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FX = new DataGridViewTextBoxColumn();
            textBox6 = new TextBox();
            groupBoxUsl_ANR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxInput_ANR.SuspendLayout();
            groupBoxOutput_ANR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartfunctions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewres_ANR).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUsl_ANR
            // 
            groupBoxUsl_ANR.Controls.Add(pictureBox1);
            groupBoxUsl_ANR.Controls.Add(textBox5);
            groupBoxUsl_ANR.Location = new Point(13, 12);
            groupBoxUsl_ANR.Name = "groupBoxUsl_ANR";
            groupBoxUsl_ANR.Size = new Size(644, 315);
            groupBoxUsl_ANR.TabIndex = 0;
            groupBoxUsl_ANR.TabStop = false;
            groupBoxUsl_ANR.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 62);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.MenuBar;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(15, 26);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(480, 91);
            textBox5.TabIndex = 0;
            textBox5.Text = "Протабулировать данную функцию на заданном диапазоне. Результат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxInput_ANR
            // 
            groupBoxInput_ANR.Controls.Add(buttonres_ANR);
            groupBoxInput_ANR.Controls.Add(buttonhelp_ANR);
            groupBoxInput_ANR.Controls.Add(textBox4);
            groupBoxInput_ANR.Controls.Add(textBox3);
            groupBoxInput_ANR.Controls.Add(textBoxstop_ANR);
            groupBoxInput_ANR.Controls.Add(textBoxstart_ANR);
            groupBoxInput_ANR.Location = new Point(13, 333);
            groupBoxInput_ANR.Name = "groupBoxInput_ANR";
            groupBoxInput_ANR.Size = new Size(644, 113);
            groupBoxInput_ANR.TabIndex = 1;
            groupBoxInput_ANR.TabStop = false;
            groupBoxInput_ANR.Text = "Ввод данных:";
            // 
            // buttonres_ANR
            // 
            buttonres_ANR.Location = new Point(482, 37);
            buttonres_ANR.Name = "buttonres_ANR";
            buttonres_ANR.Size = new Size(152, 60);
            buttonres_ANR.TabIndex = 4;
            buttonres_ANR.Text = "Выполнить";
            buttonres_ANR.UseVisualStyleBackColor = true;
            buttonres_ANR.Click += buttonres_ANR_Click;
            // 
            // buttonhelp_ANR
            // 
            buttonhelp_ANR.Location = new Point(370, 37);
            buttonhelp_ANR.Name = "buttonhelp_ANR";
            buttonhelp_ANR.Size = new Size(93, 60);
            buttonhelp_ANR.TabIndex = 3;
            buttonhelp_ANR.Text = "Справка";
            buttonhelp_ANR.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.MenuBar;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(179, 37);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(167, 20);
            textBox4.TabIndex = 0;
            textBox4.Text = "Конец шага:";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuBar;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(6, 37);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 20);
            textBox3.TabIndex = 2;
            textBox3.Text = "Старт шага:";
            // 
            // textBoxstop_ANR
            // 
            textBoxstop_ANR.Location = new Point(179, 70);
            textBoxstop_ANR.Name = "textBoxstop_ANR";
            textBoxstop_ANR.Size = new Size(167, 27);
            textBoxstop_ANR.TabIndex = 1;
            // 
            // textBoxstart_ANR
            // 
            textBoxstart_ANR.Location = new Point(6, 70);
            textBoxstart_ANR.Name = "textBoxstart_ANR";
            textBoxstart_ANR.Size = new Size(167, 27);
            textBoxstart_ANR.TabIndex = 0;
            // 
            // groupBoxOutput_ANR
            // 
            groupBoxOutput_ANR.Controls.Add(chartfunctions);
            groupBoxOutput_ANR.Controls.Add(dataGridViewres_ANR);
            groupBoxOutput_ANR.Controls.Add(textBox6);
            groupBoxOutput_ANR.Location = new Point(693, 12);
            groupBoxOutput_ANR.Name = "groupBoxOutput_ANR";
            groupBoxOutput_ANR.Size = new Size(598, 434);
            groupBoxOutput_ANR.TabIndex = 2;
            groupBoxOutput_ANR.TabStop = false;
            groupBoxOutput_ANR.Text = "Вывод данных";
            // 
            // chartfunctions
            // 
            chartArea2.Name = "ChartArea1";
            chartfunctions.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartfunctions.Legends.Add(legend2);
            chartfunctions.Location = new Point(152, 64);
            chartfunctions.Name = "chartfunctions";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartfunctions.Series.Add(series2);
            chartfunctions.Size = new Size(446, 365);
            chartfunctions.TabIndex = 2;
            chartfunctions.Text = "chart1";
            chartfunctions.Click += chartfunctions_Click;
            // 
            // dataGridViewres_ANR
            // 
            dataGridViewres_ANR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewres_ANR.Columns.AddRange(new DataGridViewColumn[] { X, FX });
            dataGridViewres_ANR.Location = new Point(20, 64);
            dataGridViewres_ANR.Name = "dataGridViewres_ANR";
            dataGridViewres_ANR.ReadOnly = true;
            dataGridViewres_ANR.RowHeadersVisible = false;
            dataGridViewres_ANR.RowHeadersWidth = 51;
            dataGridViewres_ANR.Size = new Size(111, 359);
            dataGridViewres_ANR.TabIndex = 1;
            dataGridViewres_ANR.CellContentClick += dataGridres_ANR_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // FX
            // 
            FX.HeaderText = "F(X)";
            FX.MinimumWidth = 6;
            FX.Name = "FX";
            FX.ReadOnly = true;
            FX.Width = 50;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.MenuBar;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(20, 38);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(169, 20);
            textBox6.TabIndex = 0;
            textBox6.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 466);
            Controls.Add(groupBoxOutput_ANR);
            Controls.Add(groupBoxInput_ANR);
            Controls.Add(groupBoxUsl_ANR);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 22 | Ахтариева Н. Р.";
            groupBoxUsl_ANR.ResumeLayout(false);
            groupBoxUsl_ANR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxInput_ANR.ResumeLayout(false);
            groupBoxInput_ANR.PerformLayout();
            groupBoxOutput_ANR.ResumeLayout(false);
            groupBoxOutput_ANR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartfunctions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewres_ANR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsl_ANR;
        private GroupBox groupBoxInput_ANR;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBoxstop_ANR;
        private TextBox textBoxstart_ANR;
        private TextBox textBox5;
        private Button buttonres_ANR;
        private Button buttonhelp_ANR;
        private GroupBox groupBoxOutput_ANR;
        private TextBox textBox6;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewres_ANR;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartfunctions;
    }
}
