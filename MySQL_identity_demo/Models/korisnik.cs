using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySQL_identity_demo.Models
{
    public class korisnik : osobe
    {
      
        //  status
        public enum_korisnik status { get; set; }        
        
    }
}