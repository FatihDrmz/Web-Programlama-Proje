﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models.Model
{
    [Table("Kategori")]
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }

        [Required, StringLength(50, ErrorMessage = "50 Karakter  olabilir.")]
        [DisplayName("Kategori Adı")]
        public string KategoriAd { get; set; }

        [DisplayName("Açıklama")]
        public string Aciklama { get; set; }

        public ICollection<Blog> Blogs { get; set; }
    }
}
