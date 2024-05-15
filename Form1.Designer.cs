namespace clase_practica
{
    partial class Form1
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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btn_book = new Button();
            btn_author = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 0;
            label1.Text = "Library System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_book);
            panel1.Controls.Add(btn_author);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 440);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(180, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(882, 415);
            panel2.TabIndex = 3;
            // 
            // btn_book
            // 
            btn_book.Location = new Point(12, 103);
            btn_book.Name = "btn_book";
            btn_book.Size = new Size(142, 35);
            btn_book.TabIndex = 2;
            btn_book.Text = "Book";
            btn_book.UseVisualStyleBackColor = true;
            btn_book.Click += btn_book_Click;
            // 
            // btn_author
            // 
            btn_author.Location = new Point(12, 51);
            btn_author.Name = "btn_author";
            btn_author.Size = new Size(142, 35);
            btn_author.TabIndex = 1;
            btn_author.Text = "Author";
            btn_author.UseVisualStyleBackColor = true;
            btn_author.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 440);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btn_book;
        private Button btn_author;
        private Panel panel2;
    }
}
