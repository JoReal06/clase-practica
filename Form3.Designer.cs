namespace clase_practica
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dtgv_books = new DataGridView();
            btn_search = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            cmb_authors = new ComboBox();
            label3 = new Label();
            txt_title = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_books).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dtgv_books);
            panel1.Controls.Add(btn_search);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(cmb_authors);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_title);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 363);
            panel1.TabIndex = 0;
            // 
            // dtgv_books
            // 
            dtgv_books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_books.Dock = DockStyle.Bottom;
            dtgv_books.Location = new Point(0, 135);
            dtgv_books.Name = "dtgv_books";
            dtgv_books.Size = new Size(800, 228);
            dtgv_books.TabIndex = 10;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(474, 73);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(117, 35);
            btn_search.TabIndex = 9;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(339, 73);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(117, 35);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(194, 73);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(117, 34);
            btn_update.TabIndex = 7;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(61, 73);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(117, 34);
            btn_add.TabIndex = 6;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // cmb_authors
            // 
            cmb_authors.FormattingEnabled = true;
            cmb_authors.Location = new Point(495, 23);
            cmb_authors.Name = "cmb_authors";
            cmb_authors.Size = new Size(154, 23);
            cmb_authors.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(431, 25);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 4;
            label3.Text = "Author:";
            // 
            // txt_title
            // 
            txt_title.Location = new Point(75, 25);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(253, 23);
            txt_title.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 28);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 2;
            label2.Text = "Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(309, 21);
            label1.Name = "label1";
            label1.Size = new Size(82, 40);
            label1.TabIndex = 4;
            label1.Text = "Book";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_books).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox cmb_authors;
        private Label label3;
        private TextBox txt_title;
        private Label label2;
        private Label label1;
        private Button btn_search;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private DataGridView dtgv_books;
    }
}