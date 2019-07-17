﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class Author
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }

        public Author()
        {
            Books = new List<Book>();
        }
    }
}