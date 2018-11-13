namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtodotype : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TodoTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Todoes", "TodoType_Id", c => c.Int());
            CreateIndex("dbo.Todoes", "TodoType_Id");
            AddForeignKey("dbo.Todoes", "TodoType_Id", "dbo.TodoTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Todoes", "TodoType_Id", "dbo.TodoTypes");
            DropIndex("dbo.Todoes", new[] { "TodoType_Id" });
            DropColumn("dbo.Todoes", "TodoType_Id");
            DropTable("dbo.TodoTypes");
        }
    }
}
