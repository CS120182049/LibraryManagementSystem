using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Safiproject.Models
{
    public class Library
    {
        public int ID { get; set; }
        public string Student_Name { get; set; }
        public string Student_Registrion { get; set; }
        public string Dpeartment { get; set; }
        public string Book_Name { get; set; }
        public string Author { get; set; }
        public string Libraian_Name { get; set; }
        public int Issues_Book { get; set; }
    }
}