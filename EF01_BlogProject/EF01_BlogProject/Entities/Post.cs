namespace EF01_BlogProject.Entities
{
    public class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        //Navigation Property
        public User Author  { get; set; }
        //Foreign key
        public int AuthorID { get; set; }
        public ICollection<Comment>? Comments { get; set; } = new List<Comment>();

    }
}
