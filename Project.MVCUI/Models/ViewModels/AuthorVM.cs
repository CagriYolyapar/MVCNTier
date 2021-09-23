using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Models.ViewModels
{
    public class AuthorVM
    {
        public List<Author> Authors { get; set; }
        public Author AuthorInstance { get; set; }

    }
}