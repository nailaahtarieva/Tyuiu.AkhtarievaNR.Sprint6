using System.Windows.Forms;
using Tyuiu.AkhtarievaNR.Sprint6.Task7.V11.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint6.Task7.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;

        public static int[,] LoadFromData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return result;
        }
      

        private void buttonAddFile_ANR_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromData(openFilePath);

            dataGridViewInPut_ANR.ColumnCount = columns;
            dataGridViewInPut_ANR.RowCount = rows;
            dataGridViewOutPut_ANR.ColumnCount = columns;
            dataGridViewOutPut_ANR.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_ANR.Columns[i].Width = 35;
                dataGridViewOutPut_ANR.Columns[i].Width = 35;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInPut_ANR.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_ANR.Enabled = true;
        }

        private void buttonDone_ANR_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPut_ANR.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSaveFile_ANR.Enabled = true;
        }

        private void buttonSafeFile_ANR_Click(object sender, EventArgs e)
        {
            saveFileDialogTask.FileName = "OutPutFileTask7V11.csv";
            saveFileDialogTask.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask.ShowDialog();
            string path = saveFileDialogTask.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExzist = fileInfo.Exists;
            if (fileExzist)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutPut_ANR.RowCount;
            int col = dataGridViewOutPut_ANR.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != col - 1)
                    {
                        str += dataGridViewOutPut_ANR.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutPut_ANR.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }

        private void buttonAbout_ANR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
