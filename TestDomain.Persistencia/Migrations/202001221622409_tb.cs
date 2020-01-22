namespace TestDomain.Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(maxLength: 8000, unicode: false),
                        sobrenome = c.String(maxLength: 8000, unicode: false),
                        idade = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        idProduto = c.Int(nullable: false, identity: true),
                        nome = c.String(maxLength: 8000, unicode: false),
                        fornecedor = c.String(maxLength: 8000, unicode: false),
                        marca = c.String(maxLength: 8000, unicode: false),
                        valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        cliente_id = c.Int(),
                    })
                .PrimaryKey(t => t.idProduto)
                .ForeignKey("dbo.Client", t => t.cliente_id)
                .Index(t => t.cliente_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "cliente_id", "dbo.Client");
            DropIndex("dbo.Product", new[] { "cliente_id" });
            DropTable("dbo.Product");
            DropTable("dbo.Client");
        }
    }
}
