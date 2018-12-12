using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SocialBlog.ViewModel
{
    public class SearchViewModel
    {
        [Key]
        public int PostId { get; set; }
        public string  Name { get; set; }
        public string Post { get; set; }

    }
}