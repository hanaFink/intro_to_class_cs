using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Page
    {
        private int _pagenum;
        private string _pagecontent;
        private string _pagehead;
        private int _chapternum;
        private bool _newchapter;
        
        public Page (int pagenum,string pagecontent,string pagehead,int chapternum,bool newchapter)
        {
            _pagenum = pagenum;
            _pagecontent = pagecontent;
            _pagehead = pagehead;
            _chapternum = chapternum;
            _newchapter = newchapter;
        }
        public void ReadPage ()
        {
            Console.WriteLine("{0}\nRead the page content : {1}\npage number is : {2}",(_newchapter == true?"The page head is :"+_pagehead:""),_pagecontent,_pagenum);
        }
        public void PageNumber()
        {

        }

    }
}
