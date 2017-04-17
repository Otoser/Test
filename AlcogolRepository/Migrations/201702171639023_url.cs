namespace AlcogolRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class url : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ManufacturerEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductsEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Excerpt = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        ManufacturerEntityId = c.Int(nullable: false),
                        AverageRating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ManufacturerEntities", t => t.ManufacturerEntityId, cascadeDelete: true)
                .Index(t => t.ManufacturerEntityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductsEntities", "ManufacturerEntityId", "dbo.ManufacturerEntities");
            DropIndex("dbo.ProductsEntities", new[] { "ManufacturerEntityId" });
            DropTable("dbo.ProductsEntities");
            DropTable("dbo.ManufacturerEntities");
        }
    }
}
