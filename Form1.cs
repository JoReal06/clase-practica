namespace clase_practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 menu_author = new Form2();
            menu_author.MinimizeBox = true;
            menu_author.MaximizeBox = false;
            menu_author.Visible = true;
            menu_author.StartPosition = FormStartPosition.CenterParent;
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            Form3 menu_book = new Form3();
            menu_book.MinimizeBox = true;
            menu_book.MaximizeBox = false;
            menu_book.Visible = true;
            menu_book.StartPosition = FormStartPosition.CenterParent;
        }
    }
}
