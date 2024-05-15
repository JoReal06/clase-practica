using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_practica
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.Name = txt_name.Text;
            
            AuthorRepository authorRepository = new AuthorRepository();
            authorRepository.Add(author);
            Refresh_data(authorRepository);


        }

        void Refresh_data(AuthorRepository a) 
        {
            dtgv_autores.DataSource = null;
            dtgv_autores.DataSource = a.GetAll();
        }
    }
}
