namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequird : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Todoes", "Priority_Id", "dbo.Priorities");
            DropForeignKey("dbo.Todoes", "TodoType_Id", "dbo.TodoTypes");
            DropIndex("dbo.Todoes", new[] { "Priority_Id" });
            DropIndex("dbo.Todoes", new[] { "TodoType_Id" });
            AlterColumn("dbo.Todoes", "Priority_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Todoes", "TodoType_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Todoes", "Priority_Id");
            CreateIndex("dbo.Todoes", "TodoType_Id");
            AddForeignKey("dbo.Todoes", "Priority_Id", "dbo.Priorities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Todoes", "TodoType_Id", "dbo.TodoTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Todoes", "TodoType_Id", "dbo.TodoTypes");
            DropForeignKey("dbo.Todoes", "Priority_Id", "dbo.Priorities");
            DropIndex("dbo.Todoes", new[] { "TodoType_Id" });
            DropIndex("dbo.Todoes", new[] { "Priority_Id" });
            AlterColumn("dbo.Todoes", "TodoType_Id", c => c.Int());
            AlterColumn("dbo.Todoes", "Priority_Id", c => c.Int());
            CreateIndex("dbo.Todoes", "TodoType_Id");
            CreateIndex("dbo.Todoes", "Priority_Id");
            AddForeignKey("dbo.Todoes", "TodoType_Id", "dbo.TodoTypes", "Id");
            AddForeignKey("dbo.Todoes", "Priority_Id", "dbo.Priorities", "Id");
        }
    }
}
