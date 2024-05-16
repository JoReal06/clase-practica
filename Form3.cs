using Microsoft.IdentityModel.Tokens;
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
    public partial class Form3 : Form
    {
        private readonly AuthorRepository authorRepository_;
        private readonly BookRepository bookRepository_;

        public Form3()
        {
            InitializeComponent();
            bookRepository_ = new BookRepository();
            authorRepository_ = new AuthorRepository();
            RefreshData();
        }

        private void RefreshData()
        {
            dtgv_books.DataSource = bookRepository_.GetAll();
            LoadAuthors();

        }

        private void LoadAuthors()
        {
            List<Author> authors = authorRepository_.GetAll();
            cmb_authors.DataSource = authors;
            cmb_authors.DisplayMember = "Name";
            cmb_authors.ValueMember = "AuthorId";

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string tituloL_libro = txt_title.Text;
            if (!string.IsNullOrEmpty(tituloL_libro))
            {
                Author author_Seleccionado = cmb_authors.SelectedItem as Author;
                if (author_Seleccionado != null)
                {
                    var book = new Book { Title = tituloL_libro, AuthorId = author_Seleccionado.AuthorId };
                    bookRepository_.Add(book);
                    MessageBox.Show("Libro agregado ");

                    txt_title.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un autor para el libro.");
                }
            }
            RefreshData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            string nuevo_titulo = txt_title.Text;
            if (string.IsNullOrEmpty(nuevo_titulo))
            {
                MessageBox.Show("se necesita ingresar un titulo en la caja de texto");
            }
            else
            {
                Book bookSeleccionado = dtgv_books.CurrentRow?.DataBoundItem as Book;
                if (bookSeleccionado != null)
                {

                    Author authorSeleccionado = cmb_authors.SelectedItem as Author;
                    if (authorSeleccionado != null)
                    {
                        bookSeleccionado.Title = nuevo_titulo;
                        bookSeleccionado.Author = authorSeleccionado;

                        bookRepository_.Update(bookSeleccionado);
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("es necesario seleccionar un autor para el libro.");
                    }
                }
                else
                {
                    MessageBox.Show("seleccione un libro de la lista.");
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dtgv_books.SelectedRows.Count > 0)
            {
                Book libro = dtgv_books.SelectedRows[0].DataBoundItem as Book;
                bookRepository_.Delete(libro.BookId);
                RefreshData();
            }
            else
            {
                MessageBox.Show("seleccionar un libro para eliminar.");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            string textoBusqueda = txt_title.Text.Trim();
            List<Book> librosEncontrados = bookRepository_.SearchBooksByTitle(textoBusqueda);
            dtgv_books.DataSource = librosEncontrados;
        }
    }
}
