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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        Random rnd = new Random();


        private void Start_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox2.Text);
            k = Convert.ToInt32(textBox3.Text);
            l = Convert.ToInt32(textBox4.Text);
            A = new int[n, m];
            B = new int[k, l];

            string s = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = rnd.Next(-10, 10);
                    s += A[i, j] + " ";
                }
                Matrix1_textbox.Text += s + Environment.NewLine;
                s = "";
            }

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    B[i, j] = rnd.Next(-10, 10);
                    s += B[i, j] + " ";
                }
                Matrix2_textbox.Text += s + Environment.NewLine;
                s = "";
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
