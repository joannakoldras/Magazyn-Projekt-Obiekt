namespace Backend_CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazwaKategorii = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kolors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazwaKoloru = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Markas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazwaMarki = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ubranies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazwaUbrania = c.String(),
                        Cena = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ilosc = c.Int(nullable: false),
                        IdMarki = c.Int(nullable: false),
                        IdKategorii = c.Int(nullable: false),
                        IdKoloru = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ubranies");
            DropTable("dbo.Markas");
            DropTable("dbo.Kolors");
            DropTable("dbo.Kategorias");
        }
    }
}
