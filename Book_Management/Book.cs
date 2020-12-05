using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Management
{
    class Book
    {
        public string Book_Num { get; set; }
        public string Name { get; set; }
        public int User_Num { get; set; }
        public string User_Name { get; set; }
        public bool Rent { get; set; }
        public DateTime Rent_Time { get; set; }
        public DateTime Return_Time { get; set; }
    }
}
