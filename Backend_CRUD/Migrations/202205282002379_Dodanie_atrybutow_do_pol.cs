namespace Backend_CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dodanie_atrybutow_do_pol : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Kategorias", newName: "Kategorie");
            RenameTable(name: "dbo.Kolors", newName: "Kolory");
            RenameTable(name: "dbo.Markas", newName: "Marki");
            RenameTable(name: "dbo.Ubranies", newName: "Ubrania");
            RenameColumn(table: "dbo.Kategorie", name: "Id", newName: "IdKategorii");
            RenameColumn(table: "dbo.Kolory", name: "Id", newName: "IdKoloru");
            RenameColumn(table: "dbo.Marki", name: "Id", newName: "IdMarki");
            AlterColumn("dbo.Kategorie", "NazwaKategorii", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Kolory", "NazwaKoloru", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Marki", "NazwaMarki", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Ubrania", "NazwaUbrania", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Ubrania", "IdKategorii");
            CreateIndex("dbo.Ubrania", "IdKoloru");
            CreateIndex("dbo.Ubrania", "IdMarki");
            AddForeignKey("dbo.Ubrania", "IdKategorii", "dbo.Kategorie", "IdKategorii", cascadeDelete: true);
            AddForeignKey("dbo.Ubrania", "IdKoloru", "dbo.Kolory", "IdKoloru", cascadeDelete: true);
            AddForeignKey("dbo.Ubrania", "IdMarki", "dbo.Marki", "IdMarki", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ubrania", "IdMarki", "dbo.Marki");
            DropForeignKey("dbo.Ubrania", "IdKoloru", "dbo.Kolory");
            DropForeignKey("dbo.Ubrania", "IdKategorii", "dbo.Kategorie");
            DropIndex("dbo.Ubrania", new[] { "IdMarki" });
            DropIndex("dbo.Ubrania", new[] { "IdKoloru" });
            DropIndex("dbo.Ubrania", new[] { "IdKategorii" });
            AlterColumn("dbo.Ubrania", "NazwaUbrania", c => c.String());
            AlterColumn("dbo.Marki", "NazwaMarki", c => c.String());
            AlterColumn("dbo.Kolory", "NazwaKoloru", c => c.String());
            AlterColumn("dbo.Kategorie", "NazwaKategorii", c => c.String());
            RenameColumn(table: "dbo.Marki", name: "IdMarki", newName: "Id");
            RenameColumn(table: "dbo.Kolory", name: "IdKoloru", newName: "Id");
            RenameColumn(table: "dbo.Kategorie", name: "IdKategorii", newName: "Id");
            RenameTable(name: "dbo.Ubrania", newName: "Ubranies");
            RenameTable(name: "dbo.Marki", newName: "Markas");
            RenameTable(name: "dbo.Kolory", newName: "Kolors");
            RenameTable(name: "dbo.Kategorie", newName: "Kategorias");
        }
    }
}
