using System;

namespace CSharpPress.Models
{
    public class Post
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public DateTime PublishedOn { get; set; }
    }
}
