using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFWithCodeFirstWinForm.Entity
{
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        public string KategoriAd { get; set; }
        public List<Urunler> Urunlers { get; set; }
    }
}