using System;
using System.Collections.Generic;
using System.Xml;

namespace Lab2Searcher
{
    class DomSearcher : IXmlSearcher
    {
        private string filePath;
        public DomSearcher(string _filePath)
        {
            filePath = _filePath;
        }
        public IEnumerable<Book> Search(SearchCriterias criterias_to_search)
        {
            List<Book> result = new List<Book>();
            XmlDocument doc = new XmlDocument();
            XmlReader xr = XmlReader.Create(filePath);
            doc.Load(xr);
            var books = doc.GetElementsByTagName("book");//get all books
            for (int i = 0; i < books.Count; i++)
            {
                var bookInfo = books.Item(i).ChildNodes;//get info of a book
                if (BookFitToUs(bookInfo, criterias_to_search, out Book book))
                {
                    result.Add(book);
                }
            }
            return result;
        }
        bool Validate(string ctiteria, string value)//check whether criteria exists, if so, check this criteria
        {
            return string.IsNullOrEmpty(ctiteria) || ctiteria == value;
        }

        private (string title, string author, string genre, int year, string country) ReadBook(XmlNodeList bookInfo)
        {
            string author = string.Empty;
            string title = string.Empty;
            string genre = string.Empty;
            int publish_year = default;
            string country = string.Empty;
            
            for (int i = 0; i < bookInfo.Count; i++)
            {
                var cur_node = bookInfo.Item(i);
                switch (cur_node.Name)
                {
                    case "title":
                        title = cur_node.InnerText;
                        break;
                    case "author":
                        author = cur_node.InnerText;
                        break;
                    case "genre":
                        genre = cur_node.InnerText;
                        break;
                    case "first_publication":
                        if (!int.TryParse(cur_node.InnerText, out publish_year))
                        {
                            throw new InvalidOperationException("Invalid XML file at first_publication.");//TODO: extract to string constants
                        }
                        break;
                    case "country":
                        country = cur_node.InnerText;
                        break;
                    default:
                        throw new InvalidOperationException("Unnknown element type " + cur_node.Name);
                }
            }
            return (title, author, genre, publish_year, country);
        }

        private bool BookFitToUs(XmlNodeList bookInfo, SearchCriterias criterias_to_search, out Book book)
        {
            book = default;//there will be null

            var (title, author, genre, publish_year, country) = ReadBook(bookInfo);

            if (!Validate(criterias_to_search.Title, title)) { return false; }
            if (!Validate(criterias_to_search.Author, author)) { return false; }
            if (!Validate(criterias_to_search.Genre, genre)) { return false; }
            if (criterias_to_search.PublishYearFrom.HasValue &&
                publish_year < criterias_to_search.PublishYearFrom)
            {
                return false;
            }
            if (criterias_to_search.PublishYearTo.HasValue &&
                publish_year > criterias_to_search.PublishYearTo)
            {
                return false;
            }
            if (!Validate(criterias_to_search.Country, country)) { return false; }

            book = new Book(title, author, genre, publish_year, country);
            return true;
        }
    }
}
