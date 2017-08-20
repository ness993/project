using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MySQL_identity_demo.Models
{
    public class sveDbContext : DbContext
    {
        public DbSet<zgrada> db_Zgrade { get; set; }
        public DbSet<zahtjeevi> db_Zahtjevi { get; set; }
        public DbSet<poruke> db_Poruke { get; set; }
        public DbSet<osobe> db_Osobe { get; set; }
        public DbSet<obavjesti> db_Obavjesti { get; set; }
        public DbSet<financije> db_Financije { get; set; }
        public DbSet<adresa> db_Adresa { get; set; }
    }
}