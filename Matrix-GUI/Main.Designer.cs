
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
            this.Result_textbox = new System.Windows.Forms.TextBox();
            this.CreareB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Mode = new System.Windows.Forms.ComboBox();
            this.sing = new System.Windows.Forms.Label();
            this.TA = new System.Windows.Forms.Label();
            this.TB = new System.Windows.Forms.Label();
            this.Result_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // Result_textbox
            // 
            this.Result_textbox.Location = new System.Drawing.Point(663, 199);
            this.Result_textbox.Multiline = true;
            this.Result_textbox.Name = "Result_textbox";
            this.Result_textbox.Size = new System.Drawing.Size(125, 167);
            this.Result_textbox.TabIndex = 7;
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
            // Mode
            // 
            this.Mode.FormattingEnabled = true;
            this.Mode.Items.AddRange(new object[] {
            "Сложить",
            "Вычесть",
            "Умножить",
            "Транспонировать A",
            "Транспонировать B"});
            this.Mode.Location = new System.Drawing.Point(12, 12);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(200, 28);
            this.Mode.TabIndex = 11;
            this.Mode.Text = "Выбор действия";
            this.Mode.SelectedIndexChanged += new System.EventHandler(this.Mode_SelectedIndexChanged);
            // 
            // sing
            // 
            this.sing.AutoSize = true;
            this.sing.BackColor = System.Drawing.Color.Transparent;
            this.sing.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sing.Location = new System.Drawing.Point(237, 234);
            this.sing.Name = "sing";
            this.sing.Size = new System.Drawing.Size(78, 81);
            this.sing.TabIndex = 12;
            this.sing.Text = "+";
            this.sing.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TA
            // 
            this.TA.AutoSize = true;
            this.TA.BackColor = System.Drawing.Color.Transparent;
            this.TA.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TA.Location = new System.Drawing.Point(190, 153);
            this.TA.Name = "TA";
            this.TA.Size = new System.Drawing.Size(73, 81);
            this.TA.TabIndex = 13;
            this.TA.Text = "T";
            this.TA.UseMnemonic = false;
            // 
            // TB
            // 
            this.TB.AutoSize = true;
            this.TB.BackColor = System.Drawing.Color.Transparent;
            this.TB.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TB.Location = new System.Drawing.Point(520, 153);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(73, 81);
            this.TB.TabIndex = 14;
            this.TB.Text = "T";
            this.TB.UseMnemonic = false;
            // 
            // Result_button
            // 
            this.Result_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Result_button.Font = new System.Drawing.Font("Segoe UI Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Result_button.Location = new System.Drawing.Point(552, 237);
            this.Result_button.Name = "Result_button";
            this.Result_button.Size = new System.Drawing.Size(105, 100);
            this.Result_button.TabIndex = 15;
            this.Result_button.Text = "=";
            this.Result_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Result_button.UseVisualStyleBackColor = false;
            this.Result_button.Click += new System.EventHandler(this.Result_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Размеры A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Размеры B";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Result_button);
            this.Controls.Add(this.TB);
            this.Controls.Add(this.TA);
            this.Controls.Add(this.sing);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreareB);
            this.Controls.Add(this.Result_textbox);
            this.Controls.Add(this.CreateA);
            this.Controls.Add(this.Matrix2_textbox);
            this.Controls.Add(this.Matrix1_textbox);
            this.Controls.Add(this.textBox_coumnsB);
            this.Controls.Add(this.textBox_rowsB);
            this.Controls.Add(this.textBox_rowsA);
            this.Controls.Add(this.textBox_columnsA);
            this.Name = "Main";
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
        private System.Windows.Forms.TextBox Result_textbox;
        private System.Windows.Forms.Button CreareB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Mode;
        private System.Windows.Forms.Label sing;
        private System.Windows.Forms.Label TA;
        private System.Windows.Forms.Label TB;
        private System.Windows.Forms.Button Result_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

