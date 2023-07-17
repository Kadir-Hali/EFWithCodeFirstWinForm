namespace EFWithCodeFirstWinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameKategoriIsimToKategoriAdiInKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategoriAdi", c => c.String());
            DropColumn("dbo.Kategoris", "KategoriIsim");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "KategoriIsim", c => c.String());
            DropColumn("dbo.Kategoris", "KategoriAdi");
        }
    }
}
