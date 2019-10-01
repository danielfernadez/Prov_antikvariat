using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_Antikvariatägarens_dotter
{
    class Book
    {
        public int price;
        private string name;
        private string rarity;
        private string category;
        private int actualValve;
        private bool cursed;
        private Random generator;

        public Book()
        {
           
        }
        public void PrintInfo()
        {
            Console.WriteLine("");
        }
        public int Evaluate();
        

    }

}
