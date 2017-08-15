using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MySQL_identity_demo.Models
{
    [Table "financije"]
    public class financije
    {
        [Key]
        [Display(Name = "ID Financija")]
        // id zapisa
        public int id { get; set; }
        [Required]
        [ForeignKey]
        [Display(Name = "Zgrada")]
        // zgrada
        public zgrada Zgrada { get; set; }
        // sredstva
        [Required]
        [Display(Name = "Sredstva")]
        [Range(10, 1000000)]
        public double sredstva { get; set; }
        // troškovi/dobit
        [Required]        
        [Display(Name = "Troškovi / Dobit")]
        public bool troskovi_dobit { get; set; }// 0 dobit, 1 troškovi 
        // opsi transakcije
        [Required]
        [StringLength(50)]
        [Display(Name = "Opis uplate")]
        public string opis { get; set; }

    }
}