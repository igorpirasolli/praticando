﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_e_livros.entidades
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book()
        {
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
