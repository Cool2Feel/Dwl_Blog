using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class admin
    {
        public admin()
        {
            this.article = new HashSet<article>();
        }
        public int id { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public virtual ICollection<article> article { get; set; }
    }
}