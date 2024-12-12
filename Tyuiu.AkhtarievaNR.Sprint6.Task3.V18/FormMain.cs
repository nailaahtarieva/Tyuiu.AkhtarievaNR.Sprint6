using Tyuiu.AkhtarievaNR.Sprint6.Task3.V18.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint6.Task3.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = { { -19, -19, 1, 18, 7 }, { 5, 3, -4, -6, -12 }, { -15, 6, 2, 2, -14 }, { -9, -10, 15, -5, -6 }, { -13, -15, -9, 7, 1 } };
        private void buttonHelp_ANR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнила Ахтариева Наиля Руслановна ИИПб-24-2");
        }

        private void buttonDone_ANR_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int row = res.GetUpperBound(0) + 1;
            int col = res.Length / row;
            dataGridViewMatrixDone_ANR.ColumnCount = col;
            dataGridViewMatrixDone_ANR.RowCount = row;
            for (int i = 0; i < col; i++)
            {
                dataGridViewMatrixDone_ANR.Columns[i].Width = 35;
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dataGridViewMatrixDone_ANR.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int cols = mtrx.Length / rows;
            dataGridViewmatrixres_ANR.ColumnCount = cols;
            dataGridViewmatrixres_ANR.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewmatrixres_ANR.Columns[i].Width = 35;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewmatrixres_ANR.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}

