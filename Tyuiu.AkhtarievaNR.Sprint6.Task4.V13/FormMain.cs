using System.Windows.Forms.VisualStyles;
using Tyuiu.AkhtarievaNR.Sprint6.Task4.V13.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint6.Task4.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        
        private void buttonHelp_ANR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнила Ахтариева Наиля Руслановна ИИПб-24-2");
        }

        public void buttonDone_ANR_Click(object sender, EventArgs e)
        {
            try
            {

                int a = Convert.ToInt32(textBoxStart_ANR.Text);
                int z = Convert.ToInt32(textBoxStop_ANR.Text);

                int len = ds.GetMassFunction(a, z).Length;
                double[] mas;
                mas = new double[len];
                mas = ds.GetMassFunction(a, z);

                this.chartfunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartfunction.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxDone_ANR.Text = "";
                chartfunction.Series[0].Points.Clear();

                for (int i = 0; i < len; i++)
                {
                    this.chartfunction.Series[0].Points.AddXY(a, mas[i]);
                    textBoxDone_ANR.AppendText(mas[i] + Environment.NewLine);
                    a++;
                }
            }


            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void buttonSave_ANR_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V18.txt");
                File.WriteAllText(path, textBoxDone_ANR.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен, открыть его?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        
    }
}
