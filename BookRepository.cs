using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_practica
{
    public class BookRepository:Repository<Book>
    {
        public List<Book> SearchBooksByTitle(string searchText)
        {
            using (var context = new LibraryContext())
            {
                return context.Books.Where(book => book.Title.Contains(searchText)).ToList();
            }
        }
    }
}
