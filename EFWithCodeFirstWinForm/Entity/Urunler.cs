using System.ComponentModel.DataAnnotations;

namespace EFWithCodeFirstWinForm.Entity
{
    public class Urunler
    {
        [Key]
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public string UrunMarka { get; set;}
        public string UrunKategori { get; set; }
        public int UrunStok { get; set; }
    }
}