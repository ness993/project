using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MySQL_identity_demo.Models
{
    [Table "obavjesti"]
    public class obavjesti
    {
        // Id obavjesti u bazi podataka i u listi
        [Key]
        public int id_obavjesti { get; set; }
        // Tjelo obavjesti u formi
        [Required]
        [StringLength(1024, ErrorMessage = "Obavjest je preduga, smanjite ispod 1024 znaka.")]
        public string obavjest { get; set; }
        // Tema obavjesti
        [Required]
        [StringLength(100, ErrorMessage = "Obavjest je preduga, smanjite ispod 100 znaka.")]
        public string tema { get; set; }
        // Urgencija, 1 urgentno,  0 nije; Ono što je urgentno vidi se na vrhu obavjesne liste 
        [Required]
        
        public bool urgentno { get; set; }
        // Link na Zgradu u kojoj je ta obavjest  stavljena
        [Required]
        [ForeignKey]
        public virtual zgrada Zgrada { get; set; }
    }
}