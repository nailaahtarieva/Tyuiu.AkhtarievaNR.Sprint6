using Tyuiu.AkhtarievaNR.Sprint6.Task1.V18.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint6.Task1.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonhelp_ANR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� ��������� ��������� ����� ���������� ����-24-2 ");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxres_ANR_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonres_ANR_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxstart_ANR.Text);
                int stop = Convert.ToInt32(textBoxstop_ANR.Text);
                string strline;
                int len = ds.GetMassFunction(start, stop).Length;
                double[] mas;
                mas = new double[len];
                mas = ds.GetMassFunction(start, stop);
                textBoxres_ANR.Text = "";
                textBoxres_ANR.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxres_ANR.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxres_ANR.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strline = String.Format("|{0,5:d}    |  {1, 5:f2}  |", start, mas[i]);
                    textBoxres_ANR.AppendText(strline + Environment.NewLine);
                    start++;
                }
                textBoxres_ANR.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
