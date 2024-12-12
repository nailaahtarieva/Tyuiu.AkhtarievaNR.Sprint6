namespace Tyuiu.AkhtarievaNR.Sprint6.Task0.V16
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
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            buttonresult_ANR = new Button();
            button2 = new Button();
            textBox6 = new TextBox();
            pictureBox1 = new PictureBox();
            textboxres_ANR = new TextBox();
            TextBoxVarX_ANR = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(32, 77);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 45);
            textBox1.TabIndex = 2;
            textBox1.Text = "Вычислить выражение по формуле:";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.MenuBar;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(6, 98);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(153, 23);
            textBox4.TabIndex = 4;
            textBox4.Text = "Переменная X:";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // buttonresult_ANR
            // 
            buttonresult_ANR.Location = new Point(338, 426);
            buttonresult_ANR.Name = "buttonresult_ANR";
            buttonresult_ANR.Size = new Size(184, 43);
            buttonresult_ANR.TabIndex = 6;
            buttonresult_ANR.Text = "Выполнить";
            buttonresult_ANR.UseVisualStyleBackColor = true;
            buttonresult_ANR.Click += buttonDone_Click;
            // 
            // button2
            // 
            button2.Location = new Point(261, 426);
            button2.Name = "button2";
            button2.Size = new Size(48, 43);
            button2.TabIndex = 7;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonHelp_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.MenuBar;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(6, 40);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(178, 23);
            textBox6.TabIndex = 8;
            textBox6.Text = "Результат:";
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(351, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textboxres_ANR
            // 
            textboxres_ANR.BackColor = SystemColors.ControlLight;
            textboxres_ANR.Location = new Point(6, 114);
            textboxres_ANR.Multiline = true;
            textboxres_ANR.Name = "textboxres_ANR";
            textboxres_ANR.Size = new Size(181, 59);
            textboxres_ANR.TabIndex = 10;
            textboxres_ANR.TextChanged += textBoxRes_TextChanged;
            // 
            // TextBoxVarX_ANR
            // 
            TextBoxVarX_ANR.Location = new Point(6, 124);
            TextBoxVarX_ANR.Name = "TextBoxVarX_ANR";
            TextBoxVarX_ANR.Size = new Size(153, 30);
            TextBoxVarX_ANR.TabIndex = 11;
            TextBoxVarX_ANR.TextChanged += TextBoxVarX_ANR_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(26, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 169);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TextBoxVarX_ANR);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Font = new Font("Segoe UI", 10F);
            groupBox2.Location = new Point(26, 206);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 189);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textboxres_ANR);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Font = new Font("Segoe UI", 10F);
            groupBox3.Location = new Point(333, 206);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(193, 189);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 505);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(buttonresult_ANR);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 16 | Ахтариева Н. Р.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox4;
        private Button buttonresult_ANR;
        private Button button2;
        private TextBox textBox6;
        private PictureBox pictureBox1;
        private TextBox textboxres_ANR;
        private TextBox TextBoxVarX_ANR;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
