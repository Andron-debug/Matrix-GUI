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

        private void matrix_print(int[,] matrix, int type = 2)
        {
            //Параметр type отвечает за то, куда выводить матрицу
            //0 - A
            //1 - B
            //2 - C
            string s = "";
            TextBox[] textboxs = { Matrix1_textbox, Matrix2_textbox, Result };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    s += matrix[i, j] + " ";
                }
                textboxs[type].Text += s + Environment.NewLine;
                s = "";
         
            }
            int[,] MatrixInput(int type)
            {
                //Параметр type отвечает за то, откуда взять матрицу
                //0 - A
                //1 - B
                //2 - C
                TextBox[] textboxs = { Matrix1_textbox, Matrix2_textbox, Result};
                int a = textboxs[type].Lines.GetLength(0);
                int b = textboxs[type].Lines.GetLength(1);
                int[,] matrix = new int[a,b];
                for (int i = 0; i < b; i++)
                {
                    
                }
                return matrix;
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
            matrix_print(A, 0);
            matrix_print(B, 1);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
