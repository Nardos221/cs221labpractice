using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class model
    {
         public string number { set; get; }
        public string date { set; get; }
         public  string inventorynum { set; get; }
         public  string objectname { set; get; }
         public  string count { set; get; }
         public  string price { set; get; }
         public void save()
        {
            Console.WriteLine("added successfully");
        }

    }
}
