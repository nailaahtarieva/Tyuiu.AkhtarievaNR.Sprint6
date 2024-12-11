using Tyuiu.AkhtarievaNR.Sprint6.Task2.V22.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint6.Task2.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonres_ANR_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxstart_ANR.Text);
                int stop = Convert.ToInt32(textBoxstop_ANR.Text);

                int len = ds.GetMassFunction(start, stop).Length;
                double[] mass;
                mass = new double[len];
                mass = ds.GetMassFunction(start, stop);

                this.chartfunctions.Titles.Add("График функции");

                this.chartfunctions.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartfunctions.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewres_ANR.Rows.Add(Convert.ToString(start), Convert.ToString(mass[i]));
                    this.chartfunctions.Series[0].Points.AddXY(start, mass[i]);
                    start++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonhelp_ANR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнила Ахтариева Наиля Руслановна ИИПб-24-2");
        }

        private void dataGridres_ANR_CellContentClick(object sender, EventArgs e)
        {
            //
        }

        private void chartfunctions_Click(object sender, EventArgs e)
        {

        }
    }
}