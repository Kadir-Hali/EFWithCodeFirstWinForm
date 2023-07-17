using System.Data.Entity;

namespace EFWithCodeFirstWinForm.Entity
{
    public class Context : DbContext
    {
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
    }
}