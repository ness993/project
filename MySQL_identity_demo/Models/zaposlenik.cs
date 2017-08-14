using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySQL_identity_demo.Models
{
    public class zaposlenik : osobe
    {
        // status zaposlenika
        public enum_zaposlenik status { get; set; }
    }
}