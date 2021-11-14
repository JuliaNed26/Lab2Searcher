using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Searcher
{
    interface IXmlSearcher
    {
        IEnumerable<Book> Search(SearchCriterias criterias_to_search);
    }
}
