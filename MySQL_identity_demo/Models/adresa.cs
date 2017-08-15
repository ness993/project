using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MySQL_identity_demo.Models
{
    [Table("adresa")]
    public class adresa
    {
        //id
        [Key]
        [Display(Name = "ID Adrese")]
        public int id_adrese { get; set; }
        // država
        [Required]
        [StringLength(50)]
        [Display(Name = "Država")]
        public string drzava { get; set; }
        // županija
        [Required]
        [StringLength(50)]
        [Display(Name = "Županija")]
        public string zupanija { get; set; }
        // grad
        [Required]
        [StringLength(50)]
        [Display(Name = "Grad")]
        public string grad { get; set; }
        // zip
        [Required]
        [StringLength(10)]
        [Display(Name = "Zip kod")]
        [Range(10000, 99999)]
        public int zip { get; set; }
        // ulica
        [Required]
        [StringLength(75)]
        [Display(Name = "Ulica")]
        public string ulica { get; set; }
        // broj kuce/zgrade
        [Required]
        [Range(1, 100000)]
        [Display(Name = "Kučni brojs")]
        public string broj { get; set; }
    }
}