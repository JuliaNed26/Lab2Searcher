using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab2Searcher
{
    class SaxSearcher : IXmlSearcher
    {
        private string filePath;
        public SaxSearcher(string _filePath)
        {
            filePath = _filePath;
        }
        public IEnumerable<Book> Search(SearchCriterias criterias_to_search)
        {
            List<Book> result = new List<Book>();
            using (XmlReader xr = XmlReader.Create(filePath))
            {
                while (xr.Read())
                {
                    switch (xr.NodeType)
                    {
                        case XmlNodeType.Element:// reads the element
                            if (xr.Name == "book" && BookFitToUs(xr, criterias_to_search, out Book book))//if element is book, check book by criterias
                            {
                                result.Add(book);//if book is appropriate add it to result
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            return result;
        }

        private (string author, string title, string genre, int year, string country) ReadBook(XmlReader xr)
        {
            string cur_elem = string.Empty;
            string author = string.Empty;
            string title = string.Empty;
            string genre = string.Empty;
            int publish_year = default;
            string country = string.Empty;

            while (xr.Read() && xr.Name != "book")//TODO: handle invalid book and properties double assign
            {
                switch (xr.NodeType)
                {
                    case XmlNodeType.Element:
                        cur_elem = xr.Name;
                        break;
                    case XmlNodeType.Text:
                        switch (cur_elem)
                        {
                            case "title":
                                title = xr.Value;
                                break;
                            case "author":
                                author = xr.Value;
                                break;
                            case "genre":
                                genre = xr.Value;
                                break;
                            case "first_publication":
                                if (!int.TryParse(xr.Value, out publish_year))
                                {
                                    throw new InvalidOperationException("Invalid XML file at first_publication.");//TODO: extract to string constants
                                }
                                break;
                            case "country":
                                country = xr.Value;
                                break;
                            default:
                                throw new InvalidOperationException("Unnknown element type " + cur_elem);
                        }
                        break;
                    default:
                        break;
                }

            }

            return (author, title, genre, publish_year, country);
        }

        private bool BookFitToUs(XmlReader xr, SearchCriterias criterias_to_search, out Book book)
        {
            book = default;//there will be null
            
            var (author, title, genre, publish_year, country) = ReadBook(xr);
            
            if (!Validate(criterias_to_search.Title, title)) { return false; }
            if (!Validate(criterias_to_search.Author, author)){ return false; }
            if (!Validate(criterias_to_search.Genre, genre)){ return false; }
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
            if (!Validate(criterias_to_search.Country, country)){ return false; }

            book = new Book(title, author, genre, publish_year, country);
            return true;
        }

        bool Validate(string ctiteria, string value)//check whether criteria exists, if so, check this criteria
        {
            return string.IsNullOrEmpty(ctiteria) || ctiteria == value;
        }
    }
}