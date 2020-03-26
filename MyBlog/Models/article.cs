using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class article
    {
        public int id { get; set; }

        public string title { get; set; }

        public string desc { get; set; }

        public string content { get; set; }

        public int cateid { get; set; }

        public System.DateTime time { get; set; }

        public int creator { get; set; }

        public virtual admin admin { get; set; }

        public virtual cate cate { get; set; }
    }
}