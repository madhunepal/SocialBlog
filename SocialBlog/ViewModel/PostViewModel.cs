using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SocialBlog.ViewModel
{
    public class PostViewModel
    {
        [Key]
        public string PostTitle { get; set; }
        public string PostDescription { get; set; }
        public string UserName { get; set; }
    }
}