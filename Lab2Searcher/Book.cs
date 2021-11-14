using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Searcher
{
    class Book
    {
        const int cur_year = 2021;
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Genre { get; private set; }
        public int PublishingYear { get; private set; }
        public string Country { get; private set; }
        public Book(string title, string author, string genre, int publish_year, string country)
        {
            if(publish_year > 0 && publish_year < cur_year)
            {
                PublishingYear = publish_year;
            }
            else
            {
                throw new ArgumentException("Inappropriate year");
            }
            Title = title;
            Author = author;
            Genre = genre;
            Country = country;
        }
    }
}
