using System.Data.Entity;

namespace EFWithCodeFirstWinForm.Entity
{
    public class Context : DbContext
    {
        public DbSet<Urunler> Urunlers { get; set; }
    }
}