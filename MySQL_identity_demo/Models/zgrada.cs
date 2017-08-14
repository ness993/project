using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySQL_identity_demo.Models
{
    public class zgrada
    {
        // id zgrade
        public int id { get; set; }
        // ime zgrade
        public string ime { get; set; }
        // adresa
        public adresa Adresa { get; set; }
        // obavijesti o zgradi
        public obavjesti Obavjesti { get; set; }
    }
}