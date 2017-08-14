using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySQL_identity_demo.Models
{
    public class zahtjeevi
    {
        public int id_zahtjeva { get; set; }
        public osobe ime_podnositelja { get; set; }
        public string opis { get; set; }
        public bool status { get; set; }// 1 pročitano, 0 ne pročitano 
       
        // Photo u zahtjevima
        // public string photo { get; set; }
    }
}