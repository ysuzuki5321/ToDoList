namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDeleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Deleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "Deleted");
        }
    }
}
