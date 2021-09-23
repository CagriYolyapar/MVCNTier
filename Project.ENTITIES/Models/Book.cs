using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Book:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? AuthorID { get; set; }
        public int? GenreID { get; set; }
        public int? BookShelfID { get; set; }



        //Relational Properties

        public virtual Author Author { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual BookShelf BookShelf { get; set; }


    }
}
