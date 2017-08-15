using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MySQL_identity_demo.Models
{
    [Table "poruke"]
    public class poruke
    {
        // Id poruke
        [Key]
        [Display(Name ="Id Poruke")]
        public int id_poruke { get; set; } // možda bi trebalo promjeiti tip u neki  koji može primiti više jedinstvenih oznaka
        // Osoba koja šalje poruku
        [Required]
        [ForeignKey]
        [Display(Name = "Pošiljatelj")]
        public osobe posilajtelj { get; set; }
        // Osoba koja prima poruku
        [Required]
        [ForeignKey]
        [Display(Name = "Primatelj")]
        public osobe primatelj { get; set; }
        // Tema poruke
        [Required]
        [StringLength(100, ErrorMessage ="Tema poruke ne smije biti duža od 100 znakova.")]
        [Display(Name ="Tema poruke")]
        public string tema { get; set; }
        // Tjelo poruke
        [Required]
        [StringLength(1024, ErrorMessage = "Sadržaj poruke ne smije biti duža od 1024 znakova.")]
        [Display(Name = "Sadržaj poruke")]
        public string poruka { get; set; }
        // Vrijeme slanja
        [Display(Name ="Vrijeme slanja")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime  timestamp { get; set; }
        
        // Dali je procitano ili ne         
        public bool procitano { get; set; } // 0 ako je procitano, 1 ako nije procitano
    }
}