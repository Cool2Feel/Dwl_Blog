namespace MyBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_admin_id_rm : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.articles", new[] { "admin_id1" });
            DropColumn("dbo.articles", "admin_id");
            RenameColumn(table: "dbo.articles", name: "admin_id1", newName: "admin_id");
            AlterColumn("dbo.articles", "admin_id", c => c.Int());
            CreateIndex("dbo.articles", "admin_id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.articles", new[] { "admin_id" });
            AlterColumn("dbo.articles", "admin_id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.articles", name: "admin_id", newName: "admin_id1");
            AddColumn("dbo.articles", "admin_id", c => c.Int(nullable: false));
            CreateIndex("dbo.articles", "admin_id1");
        }
    }
}
