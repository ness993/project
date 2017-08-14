using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySQL_identity_demo.Models
{
    public class financije
    {
        // id zapisa
        public int id { get; set; }
        // zgrada
        public zgrada Zgrada { get; set; }
        // sredstva
        public double sredstva { get; set; }
        // troškovi/dobit
        public bool troskovi_dobit { get; set; }// 0 dobit, 1 troškovi 
        // opsi transakcije
        public string opis { get; set; }

    }
}