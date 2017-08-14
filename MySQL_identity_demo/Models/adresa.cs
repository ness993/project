using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySQL_identity_demo.Models
{
    public class adresa
    {
        // država
        public string drzava { get; set; }
        // županija
        public string zupanija { get; set; }
        // grad
        public string grad { get; set; }
        // zip
        public int zip { get; set; }
        // ulica
        public string ulica { get; set; }
        // broj kuce/zgrade
        public string broj { get; set; }
    }
}