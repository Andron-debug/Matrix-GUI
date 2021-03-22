
namespace Matrix_GUI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Matrix1_textbox = new System.Windows.Forms.TextBox();
            this.Matrix2_textbox = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(412, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(412, 84);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 3;
            // 
            // Matrix1_textbox
            // 
            this.Matrix1_textbox.Location = new System.Drawing.Point(38, 199);
            this.Matrix1_textbox.Multiline = true;
            this.Matrix1_textbox.Name = "Matrix1_textbox";
            this.Matrix1_textbox.Size = new System.Drawing.Size(125, 167);
            this.Matrix1_textbox.TabIndex = 4;
            // 
            // Matrix2_textbox
            // 
            this.Matrix2_textbox.Location = new System.Drawing.Point(412, 199);
            this.Matrix2_textbox.Multiline = true;
            this.Matrix2_textbox.Name = "Matrix2_textbox";
            this.Matrix2_textbox.Size = new System.Drawing.Size(125, 167);
            this.Matrix2_textbox.TabIndex = 5;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(205, 145);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(146, 30);
            this.Start.TabIndex = 6;
            this.Start.Text = "Заполнить A, B";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Matrix2_textbox);
            this.Controls.Add(this.Matrix1_textbox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Main";
            this.Text = "н";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox Matrix1_textbox;
        private System.Windows.Forms.TextBox Matrix2_textbox;
        private System.Windows.Forms.Button Start;
    }
}

