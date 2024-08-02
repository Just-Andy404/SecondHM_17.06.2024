using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Book
    {
        public string Name { get; set; }
        public FullName Author { get; set; }
        public string Genre { get; set; }
        public uint Year { get; set; }

        public Book(string name, FullName author, string genre, uint year)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public override string ToString() => $"{Name}\n {Author}\n {Genre}\n {Year}\n";

    }
}
