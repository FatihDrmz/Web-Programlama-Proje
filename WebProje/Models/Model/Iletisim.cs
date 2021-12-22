using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models.Model
{
    [Table("Iletisim")]
    public class Iletisim
    {
        [Key]
        public int IletisimId { get; set; }

        [StringLength(500, ErrorMessage = "500 Karakter  olabilir.")]
        public string Adres { get; set; }

        [StringLength(50, ErrorMessage = "50 Karakter  olabilir.")]
        public string Telefon { get; set; }

        [StringLength(50, ErrorMessage = "50 Karakter  olabilir.")]
        public string Whatsapp { get; set; }

        [StringLength(50, ErrorMessage = "50 Karakter  olabilir.")]
        public string Facebook { get; set; }

        [StringLength(50, ErrorMessage = "50 Karakter  olabilir.")]
        public string Twitter { get; set; }

        [StringLength(50, ErrorMessage = "50 Karakter  olabilir.")]
        public string Instagram { get; set; }
    }
}
