using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySQL_identity_demo.Models
{
    public class poruke
    {
        // Id poruke
        public int id_poruke { get; set; }
        // Osoba koja šalje poruku
        public osobe posilajtelj { get; set; }
        // Osoba koja prima poruku
        public osobe primatelj { get; set; }
        // Tema poruke
        public string tema { get; set; }
        // Tjelo poruke
        public string poruka { get; set; }
        // Vrijeme slanja
        public DateTime  timestamp { get; set; }
        // Dali je procitano ili ne 
        public bool procitano { get; set; } // 0 ako je procitano, 1 ako nije procitano
    }
}