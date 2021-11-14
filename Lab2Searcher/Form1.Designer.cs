
namespace Lab2Searcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title_check = new System.Windows.Forms.CheckBox();
            this.genre_check = new System.Windows.Forms.CheckBox();
            this.publish_year_check = new System.Windows.Forms.CheckBox();
            this.country_check = new System.Windows.Forms.CheckBox();
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.sax_api_radioBtn = new System.Windows.Forms.RadioButton();
            this.dom_api_radioBtn = new System.Windows.Forms.RadioButton();
            this.linq_to_xml_radioBtn = new System.Windows.Forms.RadioButton();
            this.resultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.to_html_btn = new System.Windows.Forms.Button();
            this.fromPublishYear_tb = new System.Windows.Forms.TextBox();
            this.toPublishYear_tb = new System.Windows.Forms.TextBox();
            this.authorComboBox = new System.Windows.Forms.ComboBox();
            this.author_check = new System.Windows.Forms.CheckBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_check
            // 
            this.title_check.AutoSize = true;
            this.title_check.Location = new System.Drawing.Point(20, 127);
            this.title_check.Name = "title_check";
            this.title_check.Size = new System.Drawing.Size(46, 17);
            this.title_check.TabIndex = 0;
            this.title_check.Text = "Title";
            this.title_check.UseVisualStyleBackColor = true;
            // 
            // genre_check
            // 
            this.genre_check.AutoSize = true;
            this.genre_check.Location = new System.Drawing.Point(325, 83);
            this.genre_check.Name = "genre_check";
            this.genre_check.Size = new System.Drawing.Size(55, 17);
            this.genre_check.TabIndex = 1;
            this.genre_check.Text = "Genre";
            this.genre_check.UseVisualStyleBackColor = true;
            // 
            // publish_year_check
            // 
            this.publish_year_check.AutoSize = true;
            this.publish_year_check.Location = new System.Drawing.Point(632, 104);
            this.publish_year_check.Name = "publish_year_check";
            this.publish_year_check.Size = new System.Drawing.Size(110, 17);
            this.publish_year_check.TabIndex = 2;
            this.publish_year_check.Text = "Year of publishing";
            this.publish_year_check.UseVisualStyleBackColor = true;
            // 
            // country_check
            // 
            this.country_check.AutoSize = true;
            this.country_check.Location = new System.Drawing.Point(326, 127);
            this.country_check.Name = "country_check";
            this.country_check.Size = new System.Drawing.Size(62, 17);
            this.country_check.TabIndex = 3;
            this.country_check.Text = "Country";
            this.country_check.UseVisualStyleBackColor = true;
            // 
            // titleComboBox
            // 
            this.titleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Location = new System.Drawing.Point(88, 125);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(215, 21);
            this.titleComboBox.TabIndex = 4;
            // 
            // genreComboBox
            // 
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(384, 79);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(219, 21);
            this.genreComboBox.TabIndex = 5;
            // 
            // countryComboBox
            // 
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(384, 123);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(219, 21);
            this.countryComboBox.TabIndex = 7;
            // 
            // sax_api_radioBtn
            // 
            this.sax_api_radioBtn.AutoSize = true;
            this.sax_api_radioBtn.Location = new System.Drawing.Point(20, 29);
            this.sax_api_radioBtn.Name = "sax_api_radioBtn";
            this.sax_api_radioBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sax_api_radioBtn.Size = new System.Drawing.Size(66, 17);
            this.sax_api_radioBtn.TabIndex = 8;
            this.sax_api_radioBtn.TabStop = true;
            this.sax_api_radioBtn.Text = "SAX API";
            this.sax_api_radioBtn.UseVisualStyleBackColor = true;
            // 
            // dom_api_radioBtn
            // 
            this.dom_api_radioBtn.AutoSize = true;
            this.dom_api_radioBtn.Location = new System.Drawing.Point(101, 29);
            this.dom_api_radioBtn.Name = "dom_api_radioBtn";
            this.dom_api_radioBtn.Size = new System.Drawing.Size(70, 17);
            this.dom_api_radioBtn.TabIndex = 9;
            this.dom_api_radioBtn.TabStop = true;
            this.dom_api_radioBtn.Text = "DOM API";
            this.dom_api_radioBtn.UseVisualStyleBackColor = true;
            // 
            // linq_to_xml_radioBtn
            // 
            this.linq_to_xml_radioBtn.AutoSize = true;
            this.linq_to_xml_radioBtn.Location = new System.Drawing.Point(196, 29);
            this.linq_to_xml_radioBtn.Name = "linq_to_xml_radioBtn";
            this.linq_to_xml_radioBtn.Size = new System.Drawing.Size(87, 17);
            this.linq_to_xml_radioBtn.TabIndex = 10;
            this.linq_to_xml_radioBtn.TabStop = true;
            this.linq_to_xml_radioBtn.Text = "LINQ to XML";
            this.linq_to_xml_radioBtn.UseVisualStyleBackColor = true;
            // 
            // resultsRichTextBox
            // 
            this.resultsRichTextBox.Location = new System.Drawing.Point(20, 163);
            this.resultsRichTextBox.Name = "resultsRichTextBox";
            this.resultsRichTextBox.ReadOnly = true;
            this.resultsRichTextBox.Size = new System.Drawing.Size(1008, 386);
            this.resultsRichTextBox.TabIndex = 11;
            this.resultsRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(756, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(756, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "to";
            // 
            // to_html_btn
            // 
            this.to_html_btn.Location = new System.Drawing.Point(1034, 233);
            this.to_html_btn.Name = "to_html_btn";
            this.to_html_btn.Size = new System.Drawing.Size(193, 29);
            this.to_html_btn.TabIndex = 15;
            this.to_html_btn.Text = "transform to html";
            this.to_html_btn.UseVisualStyleBackColor = true;
            this.to_html_btn.Click += new System.EventHandler(this.to_html_btn_Click);
            // 
            // fromPublishYear_tb
            // 
            this.fromPublishYear_tb.Location = new System.Drawing.Point(789, 78);
            this.fromPublishYear_tb.Name = "fromPublishYear_tb";
            this.fromPublishYear_tb.Size = new System.Drawing.Size(100, 20);
            this.fromPublishYear_tb.TabIndex = 16;
            // 
            // toPublishYear_tb
            // 
            this.toPublishYear_tb.Location = new System.Drawing.Point(789, 116);
            this.toPublishYear_tb.Name = "toPublishYear_tb";
            this.toPublishYear_tb.Size = new System.Drawing.Size(100, 20);
            this.toPublishYear_tb.TabIndex = 17;
            // 
            // authorComboBox
            // 
            this.authorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorComboBox.FormattingEnabled = true;
            this.authorComboBox.Location = new System.Drawing.Point(88, 79);
            this.authorComboBox.Name = "authorComboBox";
            this.authorComboBox.Size = new System.Drawing.Size(215, 21);
            this.authorComboBox.TabIndex = 19;
            // 
            // author_check
            // 
            this.author_check.AutoSize = true;
            this.author_check.Location = new System.Drawing.Point(20, 81);
            this.author_check.Name = "author_check";
            this.author_check.Size = new System.Drawing.Size(57, 17);
            this.author_check.TabIndex = 18;
            this.author_check.Text = "Author";
            this.author_check.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(1034, 163);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(193, 29);
            this.search_btn.TabIndex = 20;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(1034, 198);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(193, 29);
            this.clear_btn.TabIndex = 21;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 601);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.authorComboBox);
            this.Controls.Add(this.author_check);
            this.Controls.Add(this.toPublishYear_tb);
            this.Controls.Add(this.fromPublishYear_tb);
            this.Controls.Add(this.to_html_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultsRichTextBox);
            this.Controls.Add(this.linq_to_xml_radioBtn);
            this.Controls.Add(this.dom_api_radioBtn);
            this.Controls.Add(this.sax_api_radioBtn);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.titleComboBox);
            this.Controls.Add(this.country_check);
            this.Controls.Add(this.publish_year_check);
            this.Controls.Add(this.genre_check);
            this.Controls.Add(this.title_check);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox title_check;
        private System.Windows.Forms.CheckBox genre_check;
        private System.Windows.Forms.CheckBox publish_year_check;
        private System.Windows.Forms.CheckBox country_check;
        private System.Windows.Forms.ComboBox titleComboBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.RadioButton sax_api_radioBtn;
        private System.Windows.Forms.RadioButton dom_api_radioBtn;
        private System.Windows.Forms.RadioButton linq_to_xml_radioBtn;
        private System.Windows.Forms.RichTextBox resultsRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button to_html_btn;
        private System.Windows.Forms.TextBox fromPublishYear_tb;
        private System.Windows.Forms.TextBox toPublishYear_tb;
        private System.Windows.Forms.ComboBox authorComboBox;
        private System.Windows.Forms.CheckBox author_check;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button clear_btn;
    }
}

