﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class cate
    {

        public cate()
        {

            this.id = 1;

            this.article = new HashSet<article>();

        }
        
        public int id { get; set; }

        public string catname { get; set; }
        
        public virtual ICollection<article> article { get; set; }
    }
}