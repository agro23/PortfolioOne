using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Models

{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [StringLength(255, ErrorMessage = "Please do not exceed 255 characters.")]
        public string Content { get; set; }

        public int UserId { get; set; }
        public int BlogPostId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; } // This would have been the user that posted the comment
        public virtual BlogPost BlogPost { get; set; }
        //public int Id { get; internal set; }

        //public Comment(int blogPostId, string author, string content)
        public Comment(int blogPostId, string content)

        {
            BlogPostId = blogPostId;
            //Author = author;
            Content = content;
        }
    }
}

