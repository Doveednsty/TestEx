namespace TestEx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnyAdd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "DateCreate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "DateCreate", c => c.DateTime(nullable: false));
        }
    }
}
