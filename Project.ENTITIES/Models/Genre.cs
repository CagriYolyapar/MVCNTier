using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Genre:BaseEntity
    {
        public string GenreName { get; set; }

        //Relational Properties
        public virtual List<Book> Books { get; set; }

    }
}
