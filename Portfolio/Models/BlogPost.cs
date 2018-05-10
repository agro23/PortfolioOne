using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    [Table("BlogPosts")]
    public class BlogPost
    {

        public BlogPost()
        {
            this.Comments = new HashSet<Comment>();
        }

        [Key]
        public int BlogPostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; } // This will be the authorization/authentication stuff
        public virtual ICollection<Comment> Comments { get; set; }

        public override bool Equals(System.Object otherBlogPost)
        {
            if (!(otherBlogPost is BlogPost))
            {
                return false;
            }
            else
            {
                BlogPost newBlogPost = (BlogPost)otherBlogPost;
                return this.BlogPostId.Equals(newBlogPost.BlogPostId);
            }
        }

        public override int GetHashCode()
        {
            return this.BlogPostId.GetHashCode();
        }
    }
}