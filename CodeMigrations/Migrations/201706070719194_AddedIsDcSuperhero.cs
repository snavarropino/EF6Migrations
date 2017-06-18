namespace CodeMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIsDcSuperhero : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Superheroes", "IsDcSuperhero", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Superheroes", "IsDcSuperhero");
        }
    }
}
