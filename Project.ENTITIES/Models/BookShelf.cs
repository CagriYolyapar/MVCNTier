using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class BookShelf:BaseEntity
    {
        public string Code { get; set; }
        public int? RoomID { get; set; }


        //Relational Properties
        public virtual List<Book> Books { get; set; }
        public virtual Room Room { get; set; }



    }
}
