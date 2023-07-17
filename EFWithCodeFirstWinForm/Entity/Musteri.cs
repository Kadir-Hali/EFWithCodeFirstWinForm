using System.ComponentModel.DataAnnotations;

namespace EFWithCodeFirstWinForm.Entity
{
    public class Musteri
    {
        [Key]
        public int MusteriID { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string MusteriSehir { get; set; }
    }
}