namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedatetype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Todoes", "Limit", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Todoes", "Limit", c => c.DateTime(nullable: false));
        }
    }
}
