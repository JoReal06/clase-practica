namespace clase_practica
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new Form2());
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new Form3());
        }

        private void ShowFormInPanel(Form formToShow)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = formToShow;
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            Panel_pantalla.Controls.Add(formToShow);
            Panel_pantalla.Tag = formToShow;
            formToShow.BringToFront();
            formToShow.Show();
        }
    }
}
