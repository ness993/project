using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MySQL_identity_demo.Models
{
    [Table "osobe"]
    public class osobe
    {
        // id osobe
        [Key]
        public int user_id { get; set; }
        // ime osobe
        [Required]
        [StringLength(50, ErrorMessage = "Vaše ime je preduga, smanjite ispod 50 znaka.")]
        [Display(Name ="Ime")]
        public string user_name { get; set; }
        // prezime osobe
        [Required]
        [StringLength(50, ErrorMessage = "Vaše srednje ime je preduga, smanjite ispod 50 znaka.")]
        [Display(Name = "Prezime")]
        public string surname { get; set; }
        // oib broj
        [Required]
        [StringLength(14, ErrorMessage = "Oib mora biti duljine 14 brojeva.")]
        [Display(Name = "OIB")]
        public int oib_number { get; set; }
        // broj osobe 
        [Required]
        [StringLength(20, ErrorMessage = "Borj telefona mora biti manji od 20 brojeva.")]
        [Display(Name = "Telefonski broj")]
        public int tel { get; set; }
        // mobitel
        [Required]
        [StringLength(20, ErrorMessage = "Borj mobitela mora biti manji od 20 brojeva.")]
        [Display(Name = "Mobilni broj")]
        public int gsm { get; set; }
        // email
        [Required]
        [StringLength(50, ErrorMessage = "Email adresa ne smije biti dulja od 50 znakova.")]
        [Display(Name = "Email Adresa")]
        public string email { get; set; }
        // adredsa osobe 
        [Required]
        [Display(Name = "Adresa osobe ")]
        [ForeignKey]
        public  adresa Adresa { get; set; }
    }
}