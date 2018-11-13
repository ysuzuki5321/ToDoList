namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Done", c => c.Boolean(nullable: false));
            AddColumn("dbo.Todoes", "DoneDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "DoneDate");
            DropColumn("dbo.Todoes", "Done");
        }
    }
}
