namespace EFWithCodeFirstWinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEntities : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategoriIsim", c => c.String());
            AddColumn("dbo.Kategoris", "KategoriDetay", c => c.String());
            AddColumn("dbo.Musteris", "MusteriSoyad", c => c.String());
            DropColumn("dbo.Kategoris", "KategoriAd");
            DropColumn("dbo.Musteris", "MusteriUnvan");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musteris", "MusteriUnvan", c => c.String());
            AddColumn("dbo.Kategoris", "KategoriAd", c => c.String());
            DropColumn("dbo.Musteris", "MusteriSoyad");
            DropColumn("dbo.Kategoris", "KategoriDetay");
            DropColumn("dbo.Kategoris", "KategoriIsim");
        }
    }
}
