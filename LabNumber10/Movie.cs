using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LabNumber10
{
    public class Movie
    {
        private string category, title, catNum;
        public Movie(string title, string category, string catNum)
        {
            this.title = title;
            this.category = category;
            this.catNum = catNum;
        }
        public string getTitle()
        {
            return title; 
        }

        public string getCategory()
        {
            return category; 
        }

        public string setcatNum()
        {
            return catNum; 
        }
    }
}
