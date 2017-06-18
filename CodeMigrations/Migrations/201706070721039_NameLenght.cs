namespace CodeMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameLenght : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Superheroes", "Name", c => c.String(maxLength: 4));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Superheroes", "Name", c => c.String());
        }
    }
}
