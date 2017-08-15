using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MySQL_identity_demo.Models
{
    [Table "zgrade"]
    public class zgrada
    {
        // id zgrade
        [Key]
        public int id { get; set; }
        // ime zgrade
        [Required]
        [Display(Name ="Ime Zgrade")]
        public string ime { get; set; }
        // adresa
        [Required]
        [Display(Name = "Adresa Zgrade")]
        [ForeignKey]
        public adresa Adresa { get; set; }
        // obavijesti o zgradi
        [Required]
        [Display(Name = "Obavjesti Zgrade")]
        [ForeignKey]
        public obavjesti Obavjesti { get; set; }
    }
}