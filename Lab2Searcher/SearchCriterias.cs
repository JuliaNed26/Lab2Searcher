using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Searcher
{
    class SearchCriterias
    {
        private int? publishYearFrom;
        private int? publishYearTo;

        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Country { get; set; }
        public int? PublishYearFrom { get { return publishYearFrom; }//nullable type int?
        set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Wrong year!");
                }
                publishYearFrom = value;
            }
        }
        public int? PublishYearTo
        {
            get { return publishYearTo; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Wrong year!");
                }
                publishYearTo = value;
            }
        }
    }
}
