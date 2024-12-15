namespace EF01_BlogProject.Entities
{
    public class Comment
    {
        public int CommentID { get; set; }
        // Foreign key for User
        public int? AuthorID { get; set; }
        // Foreign key for Post
        public int PostID { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation properties
        public User Author { get; set; }
        public Post Post { get; set; }

        public override string ToString()
        {
            return $"{Content}\n\t\t\t\tCreatedAt:{CreatedAt}";
        }
    }
}
