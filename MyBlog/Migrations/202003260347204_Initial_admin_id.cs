namespace MyBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_admin_id : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.articles", "admin_id", "dbo.admins");
            DropIndex("dbo.articles", new[] { "admin_id" });
            AddColumn("dbo.articles", "admin_id1", c => c.Int());
            AlterColumn("dbo.articles", "admin_id", c => c.Int(nullable: false));
            CreateIndex("dbo.articles", "admin_id1");
            AddForeignKey("dbo.articles", "admin_id1", "dbo.admins", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.articles", "admin_id1", "dbo.admins");
            DropIndex("dbo.articles", new[] { "admin_id1" });
            AlterColumn("dbo.articles", "admin_id", c => c.Int());
            DropColumn("dbo.articles", "admin_id1");
            CreateIndex("dbo.articles", "admin_id");
            AddForeignKey("dbo.articles", "admin_id", "dbo.admins", "id");
        }
    }
}
