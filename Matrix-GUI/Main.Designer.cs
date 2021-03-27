
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
            this.textBox_columnsA = new System.Windows.Forms.TextBox();
            this.textBox_rowsA = new System.Windows.Forms.TextBox();
            this.textBox_rowsB = new System.Windows.Forms.TextBox();
            this.textBox_coumnsB = new System.Windows.Forms.TextBox();
            this.Matrix1_textbox = new System.Windows.Forms.TextBox();
            this.Matrix2_textbox = new System.Windows.Forms.TextBox();
            this.CreateA = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.CreareB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_columnsA
            // 
            this.textBox_columnsA.Location = new System.Drawing.Point(134, 96);
            this.textBox_columnsA.Name = "textBox_columnsA";
            this.textBox_columnsA.Size = new System.Drawing.Size(50, 27);
            this.textBox_columnsA.TabIndex = 0;
            // 
            // textBox_rowsA
            // 
            this.textBox_rowsA.Location = new System.Drawing.Point(38, 96);
            this.textBox_rowsA.Name = "textBox_rowsA";
            this.textBox_rowsA.Size = new System.Drawing.Size(50, 27);
            this.textBox_rowsA.TabIndex = 1;
            // 
            // textBox_rowsB
            // 
            this.textBox_rowsB.Location = new System.Drawing.Point(368, 96);
            this.textBox_rowsB.Name = "textBox_rowsB";
            this.textBox_rowsB.Size = new System.Drawing.Size(50, 27);
            this.textBox_rowsB.TabIndex = 2;
            // 
            // textBox_coumnsB
            // 
            this.textBox_coumnsB.Location = new System.Drawing.Point(464, 96);
            this.textBox_coumnsB.Name = "textBox_coumnsB";
            this.textBox_coumnsB.Size = new System.Drawing.Size(50, 27);
            this.textBox_coumnsB.TabIndex = 3;
            // 
            // Matrix1_textbox
            // 
            this.Matrix1_textbox.Location = new System.Drawing.Point(38, 199);
            this.Matrix1_textbox.Multiline = true;
            this.Matrix1_textbox.Name = "Matrix1_textbox";
            this.Matrix1_textbox.Size = new System.Drawing.Size(146, 167);
            this.Matrix1_textbox.TabIndex = 4;
            // 
            // Matrix2_textbox
            // 
            this.Matrix2_textbox.Location = new System.Drawing.Point(368, 199);
            this.Matrix2_textbox.Multiline = true;
            this.Matrix2_textbox.Name = "Matrix2_textbox";
            this.Matrix2_textbox.Size = new System.Drawing.Size(146, 167);
            this.Matrix2_textbox.TabIndex = 5;
            // 
            // CreateA
            // 
            this.CreateA.Location = new System.Drawing.Point(38, 138);
            this.CreateA.Name = "CreateA";
            this.CreateA.Size = new System.Drawing.Size(146, 30);
            this.CreateA.TabIndex = 6;
            this.CreateA.Text = "Заполнить A";
            this.CreateA.UseVisualStyleBackColor = true;
            this.CreateA.Click += new System.EventHandler(this.CreateA_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(663, 199);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(125, 167);
            this.Result.TabIndex = 7;
            // 
            // CreareB
            // 
            this.CreareB.Location = new System.Drawing.Point(368, 138);
            this.CreareB.Name = "CreareB";
            this.CreareB.Size = new System.Drawing.Size(146, 30);
            this.CreareB.TabIndex = 8;
            this.CreareB.Text = "Заполнить B";
            this.CreareB.UseVisualStyleBackColor = true;
            this.CreareB.Click += new System.EventHandler(this.CreareB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(101, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(431, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "X";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreareB);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.CreateA);
            this.Controls.Add(this.Matrix2_textbox);
            this.Controls.Add(this.Matrix1_textbox);
            this.Controls.Add(this.textBox_coumnsB);
            this.Controls.Add(this.textBox_rowsB);
            this.Controls.Add(this.textBox_rowsA);
            this.Controls.Add(this.textBox_columnsA);
            this.Name = "Main";
            this.Text = "н";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_columnsA;
        private System.Windows.Forms.TextBox textBox_rowsA;
        private System.Windows.Forms.TextBox textBox_rowsB;
        private System.Windows.Forms.TextBox textBox_coumnsB;
        private System.Windows.Forms.TextBox Matrix1_textbox;
        private System.Windows.Forms.TextBox Matrix2_textbox;
        private System.Windows.Forms.Button CreateA;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button CreareB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

