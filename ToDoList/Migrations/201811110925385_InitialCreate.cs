namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Priorities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Num = c.Int(nullable: false),
                        DisplayValue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Todoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Limit = c.DateTime(nullable: false),
                        InsertDate = c.DateTime(nullable: false),
                        Priority_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Priorities", t => t.Priority_Id)
                .Index(t => t.Priority_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Todoes", "Priority_Id", "dbo.Priorities");
            DropIndex("dbo.Todoes", new[] { "Priority_Id" });
            DropTable("dbo.Todoes");
            DropTable("dbo.Priorities");
        }
    }
}
