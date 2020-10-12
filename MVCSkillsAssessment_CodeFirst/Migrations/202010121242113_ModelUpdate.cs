namespace MVCSkillsAssessment_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelUpdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "test");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "test", c => c.Int(nullable: false));
        }
    }
}
