using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace Lab2Searcher
{
    public partial class Form1 : Form
    {
        string filePath = "Books.xml";
        IXmlSearcher searcher;
        private void FillComboBoxes()
        {

            XDocument xdoc = XDocument.Load(filePath);
            var books = from book in xdoc.Element("read_books").Elements("book")
                        select new Book(book.Element("title").Value, book.Element("author").Value,
                          book.Element("genre").Value, Convert.ToInt32(book.Element("first_publication").Value), book.Element("country").Value);
            foreach(var book in books)
            {

                if (!titleComboBox.Items.Contains(book.Title))
                {
                    titleComboBox.Items.Add(book.Title);
                }
                if (!authorComboBox.Items.Contains(book.Author))
                {
                    authorComboBox.Items.Add(book.Author);
                }
                if (!genreComboBox.Items.Contains(book.Genre))
                {
                    genreComboBox.Items.Add(book.Genre);
                }
                if (!countryComboBox.Items.Contains(book.Country))
                {
                    countryComboBox.Items.Add(book.Country);
                }
            }
        }

        private void SetDefaultComboBoxes()
        {
            titleComboBox.SelectedItem = titleComboBox.Items[0];
            authorComboBox.SelectedItem = authorComboBox.Items[0];
            genreComboBox.SelectedItem = genreComboBox.Items[0];
            countryComboBox.SelectedItem = countryComboBox.Items[0];
        }
        public Form1()
        {
            InitializeComponent();
            FillComboBoxes();
            SetDefaultComboBoxes();
        }

        private bool DefineSearcher()
        {
            if (sax_api_radioBtn.Checked)
            {
                searcher = new SaxSearcher(filePath);
            }
            else if (dom_api_radioBtn.Checked)
            {
                searcher = new DomSearcher(filePath);
            }
            else if (linq_to_xml_radioBtn.Checked)
            {
                searcher = new LinqToXmlSearcher(filePath);
            }
            else
            {
                return false;
            }
            return true;
        }

        private void SetYearCriteria(SearchCriterias criteriasToSearch)
        {
            if (publish_year_check.Checked)
            {
                int? yearFrom = default;
                int? yearTo = default;
                try
                {
                    if (!string.IsNullOrEmpty(fromPublishYear_tb.Text))
                    {
                        yearFrom = Convert.ToInt32(fromPublishYear_tb.Text);
                        criteriasToSearch.PublishYearFrom = yearFrom;
                    }
                    if(!string.IsNullOrEmpty(toPublishYear_tb.Text))
                    {
                        yearTo = Convert.ToInt32(toPublishYear_tb.Text);
                        criteriasToSearch.PublishYearTo = yearTo;
                    }
                }
                catch (FormatException)
                {
                    criteriasToSearch.PublishYearFrom = null;
                    criteriasToSearch.PublishYearFrom = null;
                    publish_year_check.Checked = false;
                    MessageBox.Show("Wrong year!");
                }
            }
        }
        private void FillCriterias(out SearchCriterias criteriasToSearch)
        {
            criteriasToSearch = new SearchCriterias();

            if(title_check.Checked)
            {
                criteriasToSearch.Title = titleComboBox.SelectedItem.ToString();
            }

            if (author_check.Checked)
            {
                criteriasToSearch.Author = authorComboBox.SelectedItem.ToString();
            }

            if (genre_check.Checked)
            {
                    criteriasToSearch.Genre = genreComboBox.SelectedItem.ToString();
            }
            if (country_check.Checked)
            {
                criteriasToSearch.Country = countryComboBox.SelectedItem.ToString();
            }
            SetYearCriteria(criteriasToSearch);
        }

        private void PrintResult(IEnumerable<Book> apprBooks)
        {
            StringBuilder text = new StringBuilder();

            foreach(var book in apprBooks)
            {
                text.Append("Title: " + book.Title + "\n");
                text.Append("Author: " + book.Author + "\n");
                text.Append("Genre: " + book.Genre + "\n");
                text.Append("Publishing year: " + book.PublishingYear + "\n");
                text.Append("Country: " + book.Country + "\n");
                text.Append("\n\n");
            }
            resultsRichTextBox.Text = text.ToString();
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            SearchCriterias criterias_to_search;

            if(!DefineSearcher())
            {
                MessageBox.Show("Choose search strategy");
                return;
            }
            FillCriterias(out criterias_to_search);

            IEnumerable<Book> apprBooks = searcher.Search(criterias_to_search);
            PrintResult(apprBooks);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            resultsRichTextBox.Text = string.Empty;
        }

        private void to_html_btn_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load("IntermedFile.xsl");
            string htmlPath = "Books.html";
            xct.Transform(filePath, htmlPath);
            Process.Start(htmlPath);
        }
    }
}
