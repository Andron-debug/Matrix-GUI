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
        int columnsA, rowsA;
        int columnsB, rowsB;

        private void CreateA_Click(object sender, EventArgs e)
        {
            
            if ((textBox_columnsA.Text != "") & (textBox_rowsA.Text != ""))
            {
                columnsA = Convert.ToInt32(textBox_columnsA.Text); //Столбцы
                rowsA = Convert.ToInt32(textBox_rowsA.Text); //Строки
                A = new int[rowsA, columnsA];
                for (int i = 0; i < rowsA; i++)
                {
                    for (int j = 0; j < columnsA; j++)
                    {
                        A[i, j] = rnd.Next(-10, 10);
                    }
                }
                matrix_print(A, 0);
            }
            else MessageBox.Show("Введите размер матрицы");
        }
        private void CreareB_Click(object sender, EventArgs e)
        {
            if ((textBox_rowsB.Text != "") & (textBox_coumnsB.Text != ""))
            {
                rowsB = Convert.ToInt32(textBox_rowsB.Text);
                columnsB = Convert.ToInt32(textBox_coumnsB.Text);
                B = new int[rowsB, columnsB];
                for (int i = 0; i < rowsB; i++)
                {
                    for (int j = 0; j < columnsB; j++)
                    {
                        B[i, j] = rnd.Next(-10, 10);
                    }
                }
                matrix_print(B, 1);
            }
            else MessageBox.Show("Введите размер матрицы");
        }

        Random rnd = new Random();
        private void matrix_print(int[,] matrix, int type = 2)
        {
            //Параметр type отвечает за то куда выводить матрицу
            //0 - A
            //1 - B
            //2 - C
            string s = "";
            TextBox[] textboxs = { Matrix1_textbox, Matrix2_textbox, Result };
            textboxs[type].Text = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    s += matrix[i, j] + " ";
                }
                textboxs[type].Text += s + Environment.NewLine;
                s = "";
         
            }


        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
