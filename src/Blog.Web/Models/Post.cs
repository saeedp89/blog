using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Blog.Web.Models
{
    public class Post
    {
        public Post()
        {
            CreatedAt = DateTime.Now;
        }
        public int Id { get; set; }
        
        public string? Title { get; set; }

        public string? Body { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}