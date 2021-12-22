using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models.Model
{
    [Table("Hizmet")]
    public class Hizmet
    {
        [Key]
        public int HizmetId { get; set; }

        [Required,StringLength(50, ErrorMessage = "50 Karakter  olabilir.")]
        [DisplayName("Hizmet Başlık")]
        public string Baslik { get; set; }

        [DisplayName("Hizmet Açıklama")]
        public string Aciklama { get; set; }

        [DisplayName("Hizmet Resim")]
        public string ResimURL { get; set; }

    }
}
