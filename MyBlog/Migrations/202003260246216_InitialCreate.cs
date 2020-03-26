namespace MyBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.admins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.articles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        desc = c.String(),
                        content = c.String(),
                        cateid = c.Int(nullable: false),
                        time = c.DateTime(nullable: false),
                        creator = c.Int(nullable: false),
                        admin_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.admins", t => t.admin_id)
                .ForeignKey("dbo.cates", t => t.cateid, cascadeDelete: true)
                .Index(t => t.cateid)
                .Index(t => t.admin_id);
            
            CreateTable(
                "dbo.cates",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        catname = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.links",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        url = c.String(),
                        desc = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.articles", "cateid", "dbo.cates");
            DropForeignKey("dbo.articles", "admin_id", "dbo.admins");
            DropIndex("dbo.articles", new[] { "admin_id" });
            DropIndex("dbo.articles", new[] { "cateid" });
            DropTable("dbo.links");
            DropTable("dbo.cates");
            DropTable("dbo.articles");
            DropTable("dbo.admins");
        }
    }
}
