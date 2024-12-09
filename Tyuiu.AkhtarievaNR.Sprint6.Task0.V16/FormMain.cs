using Tyuiu.AkhtarievaNR.Sprint6.Task0.V16.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint6.Task0.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }

        DataService ds = new DataService();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                textboxres_ANR.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(TextBoxVarX_ANR.Text)));
            }
            catch
            {
                MessageBox.Show("Ошибка!", "Введены неверные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнила Ахтариева Наиля Руслановна ИИПб-24-2 ");
        }

        private void textBoxRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxVarX_ANR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
