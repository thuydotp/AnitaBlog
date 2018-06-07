using System;

namespace AnitaBlog.Persistence.Entities
{
    public class Article
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string MainContent { get; set; }
        public Guid AuthorId { get; set; }
        public Account Author { get; set; }
        
    }
}