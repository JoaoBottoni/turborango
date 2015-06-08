namespace TurboRango.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarEntidades : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restaurantes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Capacidade = c.Int(),
                        Nome = c.String(),
                        Localizacao_Bairro = c.String(),
                        Localizacao_Latitude = c.Double(nullable: false),
                        Localizacao_Longitude = c.Double(nullable: false),
                        Localizacao_Logradouro = c.String(),
                        Categoria = c.Int(nullable: false),
                        Contato_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contatoes", t => t.Contato_Id)
                .Index(t => t.Contato_Id);
            
            CreateTable(
                "dbo.Contatoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Site = c.String(),
                        Telefone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Restaurantes", "Contato_Id", "dbo.Contatoes");
            DropIndex("dbo.Restaurantes", new[] { "Contato_Id" });
            DropTable("dbo.Contatoes");
            DropTable("dbo.Restaurantes");
        }
    }
}
