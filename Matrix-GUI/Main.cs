using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix_GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        int[,] A, B;
        int n, m, k, l;

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        Random rnd = new Random();
        private void matrix_print(int[,] matrix, int type = 3)
        {
            //Параметр type отвечает за то куда выводить матрицу
            //1 - A
            //2 - B
            //3 - C
            string s = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    s += matrix[i, j] + " ";
                }
                if (type == 1) Matrix1_textbox.Text += s + Environment.NewLine;
                if (type == 2) Matrix2_textbox.Text += s + Environment.NewLine;
                if (type == 3) Result.Text += s + Environment.NewLine;
                s = "";
         
            }


        }
        private void Start_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox2.Text);
            k = Convert.ToInt32(textBox3.Text);
            l = Convert.ToInt32(textBox4.Text);
            A = new int[n, m];
            B = new int[k, l];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = rnd.Next(-10, 10);
                }
            }

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    B[i, j] = rnd.Next(-10, 10);
                }
            }
            matrix_print(A, 1);
            matrix_print(B, 2);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
