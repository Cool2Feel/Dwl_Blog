using System;
using System.Data.Entity;

namespace MyBlog.Models
{
    public class DwlBlogEntities : DbContext
    {
        public DwlBlogEntities() : base ("name = MyBlogEntities")
        { }

        public DbSet<admin> admin { get; set; }

        public DbSet<article> article { get; set; }

        public DbSet<cate> cate { get; set; }

        public DbSet<link> link { get; set; }
    }
}