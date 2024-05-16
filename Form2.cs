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
        private AuthorRepository authorRepository;
        public Form2()
        {
            InitializeComponent();
            authorRepository = new AuthorRepository();
            Refresh_data(authorRepository);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Author author = new Author();

                author.Name = txt_name.Text;


                authorRepository.Add(author);
                Refresh_data(authorRepository);

            }
            catch (Exception ex)
            {

                MessageBox.Show($"salio algo mal {ex.Message}");
            }

        }

        void Refresh_data(AuthorRepository a)
        {
            dtgv_autores.DataSource = null;
            dtgv_autores.DataSource = a.GetAll();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            Refresh_data(authorRepository);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string nuevo_nombre = txt_name.Text;
                if (dtgv_autores.SelectedRows.Count > 0)
                {
                    Author author_seleccionado = dtgv_autores.SelectedRows[0].DataBoundItem as Author;

                    author_seleccionado.Name = nuevo_nombre;

                    authorRepository.Update(author_seleccionado);

                }

                Refresh_data(authorRepository);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Algo salio mal {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                try
                {
                   if (dtgv_autores.SelectedRows.Count > 0)
                    { 
                    Author author = dtgv_autores.SelectedRows[0].DataBoundItem as Author;
                    authorRepository.Delete(author.AuthorId);
                    Refresh_data(authorRepository);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"ocurrio un error {ex.Message}");
                }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nombr= txt_name.Text.Trim();

            List<Author> autoresEncontrados = authorRepository.SearchAuthorsByName(nombr);

            dtgv_autores.DataSource = autoresEncontrados;
        }
    }
}
