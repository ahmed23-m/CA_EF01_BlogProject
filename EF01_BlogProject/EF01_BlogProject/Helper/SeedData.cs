using EF01_BlogProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01_BlogProject.Helper
{
    public static class SeedData
    {
        public static List<User> LoadInitialUsers()
        {
            return new List<User>
            {
                new() { ID = 1, UserName = "Ahmed Adel", Password = "0000" },
                new() { ID = 2, UserName = "Mohamed Khaled", Password = "1234" },
                new() { ID = 3, UserName = "Mirna", Password = "112233" },
                new() { ID = 4, UserName = "sarah_jones", Password = "hashed_password4" },
                new() { ID = 5, UserName = "michael_davis", Password = "hashed_password5" },
                new() { ID = 6, UserName = "emily_wilson", Password = "hashed_password6" },
                new() { ID = 7, UserName = "james_brown", Password = "hashed_password7" },
                new() { ID = 8, UserName = "olivia_miller", Password = "hashed_password8" },
                new() { ID = 9, UserName = "william_taylor", Password = "hashed_password9" },
                new() { ID = 10, UserName = "chloe_anderson", Password = "hashed_password10" }
            };
        }
        public static List<Post> LoadInitialPosts()
        {
            return new List<Post>
            {
                // Posts for User 1
                new() { PostID = 1, Title = "My First Blog Post", Content = "This is the content of my first blog post.", CreatedAt = DateTime.UtcNow, AuthorID = 1 },
                new() { PostID = 11, Title = "Learning C#", Content = "Sharing tips for beginners learning C#.", CreatedAt = DateTime.UtcNow, AuthorID = 1 },
        
                // Posts for User 2
                new() { PostID = 2, Title = "Travel to Europe", Content = "Sharing my amazing trip to Italy and France.", CreatedAt = DateTime.UtcNow, AuthorID = 2 },
                new() { PostID = 12, Title = "Hidden Gems in Europe", Content = "Discovering less-known but beautiful places in Europe.", CreatedAt = DateTime.UtcNow, AuthorID = 2 },

                // Posts for User 3
                new() { PostID = 3, Title = "Cooking Tips", Content = "Delicious recipes for pasta and pizza.", CreatedAt = DateTime.UtcNow, AuthorID = 3 },
                new() { PostID = 13, Title = "Baking Basics", Content = "How to bake the perfect bread at home.", CreatedAt = DateTime.UtcNow, AuthorID = 3 },

                // Posts for User 4
                new() { PostID = 4, Title = "Tech Reviews", Content = "Latest gadgets and software reviews.", CreatedAt = DateTime.UtcNow, AuthorID = 4 },
                new() { PostID = 14, Title = "AI Trends", Content = "Exploring the latest trends in artificial intelligence.", CreatedAt = DateTime.UtcNow, AuthorID = 4 },

                // Posts for User 5
                new() { PostID = 5, Title = "Gardening Guide", Content = "Tips for growing a beautiful garden.", CreatedAt = DateTime.UtcNow, AuthorID = 5 },
                new() { PostID = 15, Title = "Indoor Plants Care", Content = "How to keep your indoor plants healthy.", CreatedAt = DateTime.UtcNow, AuthorID = 5 },

                // Posts for User 6
                new() { PostID = 6, Title = "Fitness Journey", Content = "My fitness goals and progress.", CreatedAt = DateTime.UtcNow, AuthorID = 6 },
                new() { PostID = 16, Title = "Workout Tips", Content = "Effective exercises for a full-body workout.", CreatedAt = DateTime.UtcNow, AuthorID = 6 },

                // Posts for User 7
                new() { PostID = 7, Title = "Book Recommendations", Content = "My favorite books of all time.", CreatedAt = DateTime.UtcNow, AuthorID = 7 },
                new() { PostID = 17, Title = "Science Fiction Favorites", Content = "Top sci-fi books you should read.", CreatedAt = DateTime.UtcNow, AuthorID = 7 },

                // Posts for User 8
                new() { PostID = 8, Title = "Music Playlist", Content = "My latest music discoveries.", CreatedAt = DateTime.UtcNow, AuthorID = 8 },
                new() { PostID = 18, Title = "Indie Music Highlights", Content = "Best indie tracks of the year.", CreatedAt = DateTime.UtcNow, AuthorID = 8 },

                // Posts for User 9
                new() { PostID = 9, Title = "Photography Tips", Content = "Improving your photography skills.", CreatedAt = DateTime.UtcNow, AuthorID = 9 },
                new() { PostID = 19, Title = "Landscape Photography", Content = "How to capture stunning landscapes.", CreatedAt = DateTime.UtcNow, AuthorID = 9 },

                // Posts for User 10
                new() { PostID = 10, Title = "DIY Projects", Content = "Creative DIY projects for home decor.", CreatedAt = DateTime.UtcNow, AuthorID = 10 },
                new() { PostID = 20, Title = "Upcycling Ideas", Content = "Turn old items into something new and useful.", CreatedAt = DateTime.UtcNow, AuthorID = 10 }
            };
        }
        public static List<Comment> LoadInitialComments()
        {
            return new List<Comment>
            {
                new() { CommentID = 1, AuthorID = 2, PostID = 1, Content = "Great post! Looking forward to more content.", CreatedAt = DateTime.Parse("2024-12-14 06:00:00.000") },
                new() { CommentID = 2, AuthorID = 3, PostID = 1, Content = "I found this very helpful. Thanks for sharing!", CreatedAt = DateTime.Parse("2024-12-14 06:30:00.000") },
                new() { CommentID = 3, AuthorID = 1, PostID = 2, Content = "Your trip sounds amazing! Can't wait to visit Europe.", CreatedAt = DateTime.Parse("2024-12-14 07:00:00.000") },
                new() { CommentID = 4, AuthorID = 4, PostID = 3, Content = "I tried your recipe, and it turned out great!", CreatedAt = DateTime.Parse("2024-12-14 07:30:00.000") },
                new() { CommentID = 5, AuthorID = 5, PostID = 4, Content = "Love the detailed review. Keep it up!", CreatedAt = DateTime.Parse("2024-12-14 08:00:00.000") },
                new() { CommentID = 6, AuthorID = 6, PostID = 5, Content = "Your gardening tips are super helpful!", CreatedAt = DateTime.Parse("2024-12-14 08:30:00.000") },
                new() { CommentID = 7, AuthorID = 7, PostID = 6, Content = "Inspiring fitness journey! Keep pushing forward.", CreatedAt = DateTime.Parse("2024-12-14 09:00:00.000") },
                new() { CommentID = 8, AuthorID = 8, PostID = 7, Content = "Thanks for the book recommendations!", CreatedAt = DateTime.Parse("2024-12-14 09:30:00.000") },
                new() { CommentID = 9, AuthorID = 9, PostID = 8, Content = "Loved your playlist! Great taste in music.", CreatedAt = DateTime.Parse("2024-12-14 10:00:00.000") },
                new() { CommentID = 10, AuthorID = 10, PostID = 9, Content = "Your photography tips are a game changer.", CreatedAt = DateTime.Parse("2024-12-14 10:30:00.000") },
                new() { CommentID = 11, AuthorID = 1, PostID = 10, Content = "DIY projects are so fun! Thanks for the ideas.", CreatedAt = DateTime.Parse("2024-12-14 11:00:00.000") },
                new() { CommentID = 12, AuthorID = 2, PostID = 11, Content = "C# tips are always welcome. Great post!", CreatedAt = DateTime.Parse("2024-12-14 11:30:00.000") },
                new() { CommentID = 13, AuthorID = 3, PostID = 12, Content = "Hidden gems indeed! Adding them to my list.", CreatedAt = DateTime.Parse("2024-12-14 12:00:00.000") },
                new() { CommentID = 14, AuthorID = 4, PostID = 13, Content = "Baking is so rewarding! Great tips.", CreatedAt = DateTime.Parse("2024-12-14 12:30:00.000") },
                new() { CommentID = 15, AuthorID = 5, PostID = 14, Content = "AI trends are fascinating. Thanks for sharing!", CreatedAt = DateTime.Parse("2024-12-14 13:00:00.000") },
                new() { CommentID = 16, AuthorID = 6, PostID = 15, Content = "Indoor plants care is so important. Great guide.", CreatedAt = DateTime.Parse("2024-12-14 13:30:00.000") },
                new() { CommentID = 17, AuthorID = 7, PostID = 16, Content = "Your workout tips are super effective!", CreatedAt = DateTime.Parse("2024-12-14 14:00:00.000") },
                new() { CommentID = 18, AuthorID = 8, PostID = 17, Content = "Adding these sci-fi books to my reading list.", CreatedAt = DateTime.Parse("2024-12-14 14:30:00.000") },
                new() { CommentID = 19, AuthorID = 9, PostID = 18, Content = "Indie music is so underrated. Thanks!", CreatedAt = DateTime.Parse("2024-12-14 15:00:00.000") },
                new() { CommentID = 20, AuthorID = 10, PostID = 19, Content = "Stunning landscape photography tips!", CreatedAt = DateTime.Parse("2024-12-14 15:30:00.000") }
            };
        }

    }
}
