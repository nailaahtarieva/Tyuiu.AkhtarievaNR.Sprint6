using Tyuiu.AkhtarievaNR.Sprint6.Task5.V23.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint6.Task5.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask5V23.txt";

        private void buttonHelp_ANR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнила Ахтариева Наиля Руслановна ИИПб-24-2");
        }

        public void buttonDone_ANR_Click(object sender, EventArgs e)
        {
            dataGridViewDone_ANR.ColumnCount = 2;
            dataGridViewDone_ANR.Columns[0].Width = 20;
            dataGridViewDone_ANR.Columns[1].Width = 70;


            this.chartfunction.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartfunction.ChartAreas[0].AxisY.Title = "Ось Y";

            chartfunction.Series[0].Points.Clear();
            double[] nums = new double[ds.len];
            nums = ds.LoadFromDataFile(path);
            for (int i = 0; i < nums.Length; i++)
            {
                dataGridViewDone_ANR.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chartfunction.Series[0].Points.AddXY(i, nums[i]);
            }
        }

        
        private void buttonOpenFile_ANR_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();

        }
        
        
    }
}
