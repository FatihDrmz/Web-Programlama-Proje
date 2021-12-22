using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models.Model
{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }


        [Required, StringLength(250, ErrorMessage = "250 Karakter  olabilir.")]
        public string Baslik { get; set; }


        [Required]
        [DisplayName("Blog İçerik")]
        public string Icerik { get; set; }

        public string ResimURL { get; set; }

        public int? KategoriId { get; set; }

        public Kategori Kategori { get; set; }
    }
}
