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
            menu_author.Size = Panel_pantalla.Size;
            menu_author.TopLevel = false;
            menu_author.FormBorderStyle = FormBorderStyle.None;
            menu_author.Dock = DockStyle.Fill;
            Panel_pantalla.Controls.Add(menu_author);
            menu_author.Show();
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
