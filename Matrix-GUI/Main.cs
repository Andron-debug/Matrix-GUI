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
        int columnsA = -1;
        int rowsA = -1;
        int columnsB = -1;
        int rowsB = -1;

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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Возможные значения si и действия при них:
            //0 - Сложить
            //1 - Вычесть
            //2 - Умножить
            //3 - Транспонировать A
            //4 - Транспонировать B
            int si;
            si = Mode.SelectedIndex;
            sing.Visible = false;
            TA.Visible = false;
            TB.Visible = false;
            switch (si)
            {
                case 0:
                    sing.Text = "+";
                    sing.Visible = true;
                    break;
                case 1:
                    sing.Text = "-";
                    sing.Visible = true;
                    break;
                case 2:
                    sing.Text = "*";
                    sing.Visible = true;
                    break;
                case 3:
                    TA.Visible = true;
                    break;
                case 4:
                    TB.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void Result_button_Click(object sender, EventArgs e)
        {
            // Возможные значения si и действия при них:
            //0 - Сложить
            //1 - Вычесть
            //2 - Умножить
            //3 - Транспонировать A
            //4 - Транспонировать B
            int si;
            si = Mode.SelectedIndex;
            int[,] R;
            bool ok;
            switch (si)
            {
                case 0:// Сложить
                    ok = true;
                    if ((columnsA == -1) || (columnsB == -1))
                    {
                        ok = false;
                        MessageBox.Show("Заполните обе матрицы");
                    }
                    if ((columnsA != columnsB) || (rowsA != rowsB))
                    {
                        ok = false;
                        MessageBox.Show("Матрицы должы быть одних порядков");
                    }
                    if (ok)
                    {
                        R = new int[rowsA, columnsA];
                        for (int i = 0; i < rowsA; i++)
                        {
                            for (int j = 0; j < columnsA; j++)
                            {
                                R[i, j] = A[i, j] + B[i, j];
                            }
                        }
                        matrix_print(R);
                    }
                    break;
                case 1:// Вычесть
                    ok = true;
                    if ((columnsA == -1) || (columnsB == -1))
                    {
                        ok = false;
                        MessageBox.Show("Заполните обе матрицы");
                    }
                    if ((columnsA != columnsB) || (rowsA != rowsB))
                    {
                        ok = false;
                        MessageBox.Show("Матрицы должы быть одних порядков");
                    }
                    if (ok)
                    {
                        R = new int[rowsA, columnsA];
                        for (int i = 0; i < rowsA; i++)
                        {
                            for (int j = 0; j < columnsA; j++)
                            {
                                R[i, j] = A[i, j] - B[i, j];
                            }
                        }
                        matrix_print(R);
                    }
                    break;
                case 2: // Умножить
                    ok = true;
                    if ((columnsA == -1) || (columnsB == -1))
                    {
                        ok = false;
                        MessageBox.Show("Заполните обе матрицы");
                    }
                    if (columnsA != rowsB)
                    {
                        ok = false;
                        MessageBox.Show("Матрицы не возможно перемножить");
                    }
                    R = new int[rowsA, columnsB];
                    for (int i = 0; i <rowsA; i++)
                    {
                        for( int j = 0; j<columnsB; j++)
                        {
                            R[i, j] = 0;
                        }
                    }

                    for (int i = 0; i < rowsA; i++)
                    {
                        for (int j = 0; j < columnsB; j++)
                        {
                            for (int k = 0; k < rowsB; k++)
                            {
                                R[i, j] += A[i, k] * B[k, j];
                            }
                        }
                    }

                    matrix_print(R);
                    break;
                case 3: // Транспонировать А
                    ok = true;
                    if (columnsA == -1)
                    {
                        ok = false;
                        MessageBox.Show("Заполните матрицу А");
                    }
                    R = new int[columnsA, rowsA];
                    for (int i = 0; i <rowsA; i++)
                    {
                        for(int j = 0; j <columnsA; j++)
                        {
                            R[j, i] = A[i, j];
                        }
                    }
                    matrix_print(R);
                    break;
                case 4:// Транспонировать В
                    ok = true;
                    if (columnsB== -1)
                    {
                        ok = false;
                        MessageBox.Show("Заполните матрицу В");
                    }
                    R = new int[columnsB, rowsB];
                    for (int i = 0; i < rowsB; i++)
                    {
                        for (int j = 0; j < columnsB; j++)
                        {
                            R[j, i] = B[i, j];
                        }
                    }
                    matrix_print(R);
                    break;
                default:
                    MessageBox.Show("Выберите действие");
                    break;
                        }
                   }

        Random rnd = new Random();
        private void matrix_print(int[,] matrix, int type = 2)
        {
            //Параметр type отвечает за то куда выводить матрицу
            //0 - A
            //1 - B
            //2 - C
            string s = "";
            TextBox[] textboxs = { Matrix1_textbox, Matrix2_textbox, Result_textbox };
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
            sing.Visible = false;
            TA.Visible = false;
            TB.Visible = false;
        }
    }
}
