using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class BlogPost
    {
        public Guid BlogPostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateTimePosted { get; set; }
        public string ImageUrl { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
