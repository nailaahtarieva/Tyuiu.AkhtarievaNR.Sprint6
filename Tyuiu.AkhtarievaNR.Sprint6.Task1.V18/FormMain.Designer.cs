namespace Tyuiu.AkhtarievaNR.Sprint6.Task1.V18
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
            groupBoxUsl_ANR = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            groupBoxIntput_ANR = new GroupBox();
            textBoxstop_ANR = new TextBox();
            textBoxstart_ANR = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            buttonhelp_ANR = new Button();
            buttonres_ANR = new Button();
            groupBoxOutput_ANR = new GroupBox();
            textBoxres_ANR = new TextBox();
            textBox6 = new TextBox();
            groupBoxUsl_ANR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxIntput_ANR.SuspendLayout();
            groupBoxOutput_ANR.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUsl_ANR
            // 
            groupBoxUsl_ANR.Controls.Add(pictureBox1);
            groupBoxUsl_ANR.Controls.Add(textBox1);
            groupBoxUsl_ANR.Location = new Point(12, 12);
            groupBoxUsl_ANR.Name = "groupBoxUsl_ANR";
            groupBoxUsl_ANR.Size = new Size(617, 307);
            groupBoxUsl_ANR.TabIndex = 0;
            groupBoxUsl_ANR.TabStop = false;
            groupBoxUsl_ANR.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 48);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(20, 36);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(405, 61);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать данную функцию на заданном диапазоне. Результат вывести в виде таблицы.  ";
            // 
            // groupBoxIntput_ANR
            // 
            groupBoxIntput_ANR.Controls.Add(textBoxstop_ANR);
            groupBoxIntput_ANR.Controls.Add(textBoxstart_ANR);
            groupBoxIntput_ANR.Controls.Add(textBox3);
            groupBoxIntput_ANR.Controls.Add(textBox2);
            groupBoxIntput_ANR.Location = new Point(12, 325);
            groupBoxIntput_ANR.Name = "groupBoxIntput_ANR";
            groupBoxIntput_ANR.Size = new Size(343, 113);
            groupBoxIntput_ANR.TabIndex = 1;
            groupBoxIntput_ANR.TabStop = false;
            groupBoxIntput_ANR.Text = "Ввод данных:";
            // 
            // textBoxstop_ANR
            // 
            textBoxstop_ANR.Location = new Point(180, 68);
            textBoxstop_ANR.Name = "textBoxstop_ANR";
            textBoxstop_ANR.Size = new Size(152, 27);
            textBoxstop_ANR.TabIndex = 2;
            // 
            // textBoxstart_ANR
            // 
            textBoxstart_ANR.Location = new Point(6, 68);
            textBoxstart_ANR.Name = "textBoxstart_ANR";
            textBoxstart_ANR.Size = new Size(152, 27);
            textBoxstart_ANR.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuBar;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(180, 35);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 20);
            textBox3.TabIndex = 1;
            textBox3.Text = "Конец шага:";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(6, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 20);
            textBox2.TabIndex = 1;
            textBox2.Text = "Старт шага:";
            // 
            // buttonhelp_ANR
            // 
            buttonhelp_ANR.BackColor = Color.PaleTurquoise;
            buttonhelp_ANR.Location = new Point(376, 346);
            buttonhelp_ANR.Name = "buttonhelp_ANR";
            buttonhelp_ANR.Size = new Size(87, 74);
            buttonhelp_ANR.TabIndex = 1;
            buttonhelp_ANR.Text = "Справка";
            buttonhelp_ANR.UseVisualStyleBackColor = false;
            buttonhelp_ANR.Click += buttonhelp_ANR_Click;
            // 
            // buttonres_ANR
            // 
            buttonres_ANR.BackColor = Color.PaleGreen;
            buttonres_ANR.Location = new Point(480, 346);
            buttonres_ANR.Name = "buttonres_ANR";
            buttonres_ANR.Size = new Size(149, 74);
            buttonres_ANR.TabIndex = 2;
            buttonres_ANR.Text = "Выполнить";
            buttonres_ANR.UseVisualStyleBackColor = false;
            buttonres_ANR.Click += buttonres_ANR_Click;
            // 
            // groupBoxOutput_ANR
            // 
            groupBoxOutput_ANR.Controls.Add(textBoxres_ANR);
            groupBoxOutput_ANR.Controls.Add(textBox6);
            groupBoxOutput_ANR.Location = new Point(665, 12);
            groupBoxOutput_ANR.Name = "groupBoxOutput_ANR";
            groupBoxOutput_ANR.Size = new Size(290, 426);
            groupBoxOutput_ANR.TabIndex = 3;
            groupBoxOutput_ANR.TabStop = false;
            groupBoxOutput_ANR.Text = "Вывод данных:";
            // 
            // textBoxres_ANR
            // 
            textBoxres_ANR.Location = new Point(24, 78);
            textBoxres_ANR.Multiline = true;
            textBoxres_ANR.Name = "textBoxres_ANR";
            textBoxres_ANR.Size = new Size(253, 330);
            textBoxres_ANR.TabIndex = 1;
            textBoxres_ANR.TextChanged += textBoxres_ANR_TextChanged;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.MenuBar;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(24, 36);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(253, 20);
            textBox6.TabIndex = 0;
            textBox6.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 450);
            Controls.Add(groupBoxOutput_ANR);
            Controls.Add(buttonres_ANR);
            Controls.Add(buttonhelp_ANR);
            Controls.Add(groupBoxIntput_ANR);
            Controls.Add(groupBoxUsl_ANR);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 16 | Ахтариева Н. Р.";
            groupBoxUsl_ANR.ResumeLayout(false);
            groupBoxUsl_ANR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxIntput_ANR.ResumeLayout(false);
            groupBoxIntput_ANR.PerformLayout();
            groupBoxOutput_ANR.ResumeLayout(false);
            groupBoxOutput_ANR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsl_ANR;
        private TextBox textBox1;
        private GroupBox groupBoxIntput_ANR;
        private TextBox textBoxstop_ANR;
        private TextBox textBoxstart_ANR;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button buttonhelp_ANR;
        private Button buttonres_ANR;
        private GroupBox groupBoxOutput_ANR;
        private TextBox textBoxres_ANR;
        private TextBox textBox6;
        private PictureBox pictureBox1;
    }
}
