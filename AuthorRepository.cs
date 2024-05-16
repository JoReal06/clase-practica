using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_practica
{
    public class AuthorRepository: Repository<Author>
    {
        public List<Author> SearchAuthorsByName(string name)
        {
            return GetAll().Where(author => author.Name.Contains(name)).ToList();
        }
    }
}
