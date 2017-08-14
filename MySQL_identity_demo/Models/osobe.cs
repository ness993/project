using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySQL_identity_demo.Models
{
    public class osobe
    {
        // id osobe
        public int user_id { get; set; }
        // ime osobe
        public string user_name { get; set; }
        // prezime osobe
        public string surname { get; set; }
        // oib broj
        public int oib_number { get; set; }
        // broj osobe 
        public int tel { get; set; }
        // mobitel
        public int gsm { get; set; }
        // email
        public string email { get; set; }
        // adredsa osobe 
        public  adresa Adresa { get; set; }
    }
}