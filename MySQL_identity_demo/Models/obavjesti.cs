using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySQL_identity_demo.Models
{
    public class obavjesti
    {
        // Id obavjesti u bazi podataka i u listi
        public int id_obavjesti { get; set; }
        // Tjelo obavjesti u formi
        public string obavjest { get; set; }
        // Tema obavjesti
        public string tema { get; set; }
        // Urgencija, 1 urgentno,  0 nije; Ono što je urgentno vidi se na vrhu obavjesne liste 
        public bool urgentno { get; set; }
        // Link na Zgradu u kojoj je ta obavjest  stavljena
        public virtual zgrada Zgrada { get; set; }
    }
}