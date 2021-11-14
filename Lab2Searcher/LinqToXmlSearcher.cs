using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2Searcher
{
    class LinqToXmlSearcher : IXmlSearcher
    {
        private string filePath;
        public LinqToXmlSearcher(string _filePath)
        {
            filePath = _filePath;
        }
        bool Validate(string ctiteria, string value)//check whether criteria exists, if so, check this criteria
        {
            return string.IsNullOrEmpty(ctiteria) || ctiteria == value;
        }
        bool BookAppropriate(SearchCriterias criterias_to_search, string title, string author, string genre,
            int publish_year, string country)
        {
            return Validate(criterias_to_search.Title, title) &&
                Validate(criterias_to_search.Author, author) &&
                Validate(criterias_to_search.Genre, genre) &&
                !(criterias_to_search.PublishYearTo.HasValue &&
                publish_year > criterias_to_search.PublishYearTo) &&
                !(criterias_to_search.PublishYearFrom.HasValue &&
                publish_year < criterias_to_search.PublishYearFrom) &&
                Validate(criterias_to_search.Country, country);
        }
        public IEnumerable<Book> Search(SearchCriterias criterias_to_search)
        {
            XDocument xdoc = XDocument.Load(filePath);
            var result = from book in xdoc.Element("read_books").Elements("book")
                         where BookAppropriate(criterias_to_search, book.Element("title").Value, book.Element("author").Value,
                          book.Element("genre").Value, Convert.ToInt32(book.Element("first_publication").Value), book.Element("country").Value)
                         select new Book(book.Element("title").Value, book.Element("author").Value,
                          book.Element("genre").Value, Convert.ToInt32(book.Element("first_publication").Value), book.Element("country").Value);
            return result;
        }
    }
}
