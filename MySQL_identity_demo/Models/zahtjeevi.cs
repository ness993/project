using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MySQL_identity_demo.Models
{
    [Table "zahtjeevi"]
    public class zahtjeevi
    {
        // Id  zahtjeva
        [Key]
        public int id_zahtjeva { get; set; }
        // ime pošiljatelja
        [Required]
        [ForeignKey]
        [Display(Name ="Pošiljatelj")]
        public osobe ime_podnositelja { get; set; }
        // opis
        [Required]
        [Display(Name ="Opis zahtjeva")]
        public string opis { get; set; }
        // Status
        [Display(Name="Status zahtjevas")]
        public bool status { get; set; }// 1 pročitano, 0 ne pročitano 
       
        // Photo u zahtjevima
        // public string photo { get; set; }
    }
}