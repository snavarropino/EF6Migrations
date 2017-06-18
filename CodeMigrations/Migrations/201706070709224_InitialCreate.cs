namespace CodeMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SecretIdentities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Identity = c.String(),
                        Superhero_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Superheroes", t => t.Superhero_Id)
                .Index(t => t.Superhero_Id);
            
            CreateTable(
                "dbo.Superheroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SecretIdentities", "Superhero_Id", "dbo.Superheroes");
            DropIndex("dbo.SecretIdentities", new[] { "Superhero_Id" });
            DropTable("dbo.Superheroes");
            DropTable("dbo.SecretIdentities");
        }
    }
}
