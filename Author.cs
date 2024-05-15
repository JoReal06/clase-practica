using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_practica
{
    public class Author
    {
        public int AuthorId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
