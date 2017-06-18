namespace CodeMigrationsAutomaticallyApplied.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsDCSuperHeroNotNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Superheroes", "IsDcSuperhero", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Superheroes", "IsDcSuperhero", c => c.Boolean());
        }
    }
}
