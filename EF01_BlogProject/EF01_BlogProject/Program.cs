using EF01_BlogProject.Data;
using EF01_BlogProject.Entities;
using EF01_BlogProject.Helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;

class Program
{
    public static int UserID = 0;
    public static async Task Main()
    {
        // Load Initial Data
        #region SeedingData
        using (var context = new AppDbContext())
        {
            await context.Database.EnsureCreatedAsync();

            if (!await context.Set<User>().AnyAsync())
            {
                context.Set<User>().AddRange(SeedData.LoadInitialUsers());
            }
            if (!await context.Set<Post>().AnyAsync())
            {
                context.Set<Post>().AddRange(SeedData.LoadInitialPosts());
            }
            if (!await context.Set<Comment>().AnyAsync())
            {
                context.Set<Comment>().AddRange(SeedData.LoadInitialComments());
            }
            await context.SaveChangesAsync();
        }
        #endregion

        #region CopyRights
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\r\n__________            _____  .__                       .___    _____       .___     .__   \r\n" +
            "\\______   \\___.__.   /  _  \\ |  |__   _____   ____   __| _/   /  _  \\    __| _/____ |  |  \r\n" +
            " |    |  _<   |  |  /  /_\\  \\|  |  \\ /     \\_/ __ \\ / __ |   /  /_\\  \\  / __ |/ __ \\|  |  \r\n" +
            " |    |   \\\\___  | /    |    \\   Y  \\  Y Y  \\  ___// /_/ |  /    |    \\/ /_/ \\  ___/|  |__\r\n" +
            " |______  // ____| \\____|__  /___|  /__|_|  /\\___  >____ |  \\____|__  /\\____ |\\___  >____/\r\n" +
            "        \\/ \\/              \\/     \\/      \\/     \\/     \\/          \\/      \\/    \\/      \r\n");
        Thread.Sleep(3000);
        Console.ResetColor();
        Console.Clear();
        #endregion

        WelcomeScreen();
        HomeScreen();

        Console.ReadKey();
    }
    public static void WelcomeScreen()
    {
        Console.WriteLine(
            "┌──────────────────────────────────────────────────────────────┐\r\n" +
            "│                                                              │\r\n" +
            "│                                                              │\r\n" +
            "│                                                              │\r\n" +
            "│             ┌───────────────────────────────────┐            │\r\n" +
            "│             │      ┌─────────────────────┐      │            │\r\n" +
            "│             │      │ Welcome To Our Blog │      │            │\r\n" +
            "│             │      └─────────────────────┘      │            │\r\n" +
            "│             │                                   │            │\r\n" +
            "│             │                                   │            │\r\n" +
            "│             │                                   │            │\r\n" +
            "│             │                                   │            │\r\n" +
            "│             │      ┌─────────┐  ┌────────┐      │            │\r\n" +
            "│             │      │  Login  │  │Register│      │            │\r\n" +
            "│             │      └─────────┘  └────────┘      │            │\r\n" +
            "│             │          [1]          [2]         │            │\r\n" +
            "│             └───────────────────────────────────┘            │\r\n" +
            "│                                                              │\r\n" +
            "│                                                              │\r\n" +
            "│                                                              │\r\n" +
            "│                                                              │\r\n" +
            "└──────────────────────────────────────────────────────────────┘");

        while (true)
        {
            Console.Write("\nEnter Your Choice: > ");
            var input = Console.ReadKey();

            if (input.Key == ConsoleKey.D1) // Login Page
            {
                Console.Clear();
                
                Console.WriteLine(
                    "┌──────────────────────────────────────────────────────────────┐\r\n" +
                    "│                                                              │\r\n" +
                    "│                                                              │\r\n" +
                    "│                                                              │\r\n" +
                    "│             ┌───────────────────────────────────┐            │\r\n" +
                    "│             │      ┌─────────────────────┐      │            │\r\n" +
                    "│             │      │    Account Login    │      │            │\r\n" +
                    "│             │      └─────────────────────┘      │            │\r\n" +
                    "│             │      Enter your Name              │            │\r\n" +
                    "│             │          ┌──────────────┐         │            │\r\n" +
                    "│             │          │              │         │            │\r\n" +
                    "│             │          └──────────────┘         │            │\r\n" +
                    "│             │      Enter Your Password          │            │\r\n" +
                    "│             │          ┌──────────────┐         │            │\r\n" +
                    "│             │          │              │         │            │\r\n" +
                    "│             │          └──────────────┘         │            │\r\n" +
                    "│             └───────────────────────────────────┘            │\r\n" +
                    "│                                                              │\r\n" +
                    "│                                                              │\r\n" +
                    "│                                                              │\r\n" +
                    "│                                                              │\r\n" +
                    "└──────────────────────────────────────────────────────────────┘"
                    );
                
                using (var context = new AppDbContext())
                {
                    while (true)
                    {
                        // Get User Input
                        Console.SetCursorPosition(26, 10);
                        var username = Console.ReadLine();
                        Console.SetCursorPosition(26, 14);
                        var password = Console.ReadLine();

                        // Validation
                        var user = context.Users.Where(u => u.UserName == username)
                                        .SingleOrDefault(u => u.Password == password);
                        UserID = user.ID;
                        if (user is not null)
                        {
                            Console.SetCursorPosition(20, 19);
                            Console.WriteLine("Logged in Successfully!!");
                            break;
                        }
                        Console.WriteLine("Wrong username or password");
                    }
                }
                Console.Clear();
                break;
            }
            else if (input.Key == ConsoleKey.D2) // Register Page
            {
                Console.Clear();

                Console.WriteLine(
                    "┌──────────────────────────────────────────────────────────────┐\r\n" +
                    "│                                                              │\r\n" +
                    "│                                                              │\r\n" +
                    "│                                                              │\r\n" +
                    "│             ┌───────────────────────────────────┐            │\r\n" +
                    "│             │      ┌─────────────────────┐      │            │\r\n" +
                    "│             │      │   Account Register  │      │            │\r\n" +
                    "│             │      └─────────────────────┘      │            │\r\n" +
                    "│             │      Enter your Name              │            │\r\n" +
                    "│             │          ┌──────────────┐         │            │\r\n" +
                    "│             │          │              │         │            │\r\n" +
                    "│             │          └──────────────┘         │            │\r\n" +
                    "│             │      Enter Your Password          │            │\r\n" +
                    "│             │          ┌──────────────┐         │            │\r\n" +
                    "│             │          │              │         │            │\r\n" +
                    "│             │          └──────────────┘         │            │\r\n" +
                    "│             └───────────────────────────────────┘            │\r\n" +
                    "│                                                              │\r\n" +
                    "│                                                              │\r\n" +
                    "│                                                              │\r\n" +
                    "│                                                              │\r\n" +
                    "└──────────────────────────────────────────────────────────────┘"
                    );
                using (var context = new AppDbContext())
                {
                    while (true)
                    {
                        // Get User Input
                        Console.SetCursorPosition(26, 10);
                        var username = Console.ReadLine();
                        Console.SetCursorPosition(26, 14);
                        var password = Console.ReadLine();


                        if (!username.IsNullOrEmpty() && !password.IsNullOrEmpty())
                        {
                            var users = context.Users;
                            UserID = users.Count() + 1;
                            // Insert Data
                            var user = users.Add(new User {ID = UserID, UserName = username, Password = password });

                            context.SaveChanges();
                            Console.SetCursorPosition(20, 19);
                            Console.WriteLine("Registered Successfully!!");
                            break;
                        }
                        Console.WriteLine("Wrong Data Entered");
                    }
                }
                Console.Clear();
                break;
            }
            else
            {
                Console.WriteLine("\nWrong Choice Entered");
            }
        }
    }
    public static void HomeScreen()
    {
        int currentIndex = 0; // Track the current post index
        bool isHighlighted = false;
        int page = 1;
        int pageSize = 3;
        ConsoleKey key;

        using (var context = new AppDbContext())
        { 
            do
            {
                var posts = context.Posts.Include(p => p.Author).Include(p=>p.Comments).Skip((page - 1) * pageSize).Take(pageSize).ToList();
                var posts_count = posts.Count();
                if (posts_count == 0)
                {
                    posts_count = 3;
                    page = 1;
                    currentIndex = 0;
                    posts = context.Posts.Include(p => p.Author).Skip((page - 1) * pageSize).Take(pageSize).ToList();
                }
                Console.Clear(); // Clear the console
                Console.WriteLine("=> Use (Up) and (Down) arrows to navigate between posts.\t=> Press 'Enter' to view the full post with comments.");
                Console.WriteLine("=> Press 'Esc' to exit.\t\t\t\t\t\t=> Press'N' to Create a New Post");

                // Reset indexer to 0 for each render
                int indexer = 0;

                foreach (var post in posts)
                {
                    isHighlighted = (indexer == currentIndex);
                    PrintPost(post.Author.UserName, post.Title, post.Content, post.CreatedAt, isHighlighted);
                    indexer++;
                }

                key = Console.ReadKey(true).Key;

                // Navigate up and down
                if (key == ConsoleKey.UpArrow)
                {
                    if (currentIndex == 0) // If at the top of the current page
                    {
                        if (page > 1) // If not on the first page, move to the previous page
                        {
                            page--;
                            currentIndex = pageSize - 1; // Set index to the last item on the previous page
                        }
                        else
                        {
                            currentIndex = 0; // Stay at the top if already on the first page
                        }
                    }
                    else
                    {
                        currentIndex--; // Move up within the current page
                    }
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    currentIndex = (currentIndex + 1) % posts_count; // Move down

                    if (currentIndex == 0 && currentIndex != pageSize - 1)
                    {
                        page++;
                    }
                }
                else if (key == ConsoleKey.Enter)
                {
                    ShowFullPost(posts[currentIndex]); // Show full post with comments
                }
                else if(key == ConsoleKey.N)
                {
                    CreatNewPost();
                }
            } while (key != ConsoleKey.Escape);
        }
    }
    public static void PrintPost(string AuthorName, string Title, string Content, DateTime CreatedAt,bool isHighlighted = false)
    {
        // Highlight Current Post
        Console.ForegroundColor = isHighlighted ? ConsoleColor.DarkCyan : ConsoleColor.White;

        // Split the content into lines with a max width of 90 characters
        int maxWidth = 88;
        var contentLines = SplitContentIntoLines(Content, maxWidth);

        Console.WriteLine(
            "    ┌─────────────────────────────────────────────────────────────────────────────────────────────────┐");
        Console.WriteLine(
            $"    │ ┌─────────────────────────┐ ┌────────────────────────────────────────────────────────────────┐  │");
        Console.WriteLine(
            $"    │ │ Author: {AuthorName,-15} │ │ Title: {Title,-55} │  │");
        Console.WriteLine(
            $"    │ └─────────────────────────┘ └────────────────────────────────────────────────────────────────┘  │");

        Console.WriteLine(
            $"    │ ┌──────────────────────────────────────────────────────────────────────────────────────────┐    │");

        // Print each line of the content
        foreach (var line in contentLines)
        {
            Console.WriteLine($"    │ │ {line,-88} │    │");
        }

        Console.WriteLine(
            $"    │ └──────────────────────────────────────────────────────────────────────────────────────────┘    │");
        Console.WriteLine(
            $"    │                                                           CreatedAt: {CreatedAt,-25}  │");
        Console.WriteLine(
            "    └─────────────────────────────────────────────────────────────────────────────────────────────────┘");

        //Set the Color Back
        Console.ForegroundColor = ConsoleColor.White;
    }

    // Helper method to split content into lines of a specific width
    private static List<string> SplitContentIntoLines(string content, int maxWidth)
    {
        var lines = new List<string>();
        for (int i = 0; i < content.Length; i += maxWidth)
        {
            lines.Add(content.Substring(i, Math.Min(maxWidth, content.Length - i)));
        }
        return lines;
    }

    // Function to show the Full Post with Comments
    public static void ShowFullPost(Post post)
    {
        Console.Clear();
        PrintPost(post.Author.UserName, post.Title, post.Content, post.CreatedAt, true);

        Console.WriteLine("\nComments:");
        if (post.Comments is not null)
        {
            foreach (var comment in post.Comments)
            {
                Console.WriteLine($"-[{(comment.Author is null ? "Deleted Account" : comment.Author?.UserName)}]\n\t{comment}");
            }
        }
        // Creat New Comment
        Console.WriteLine("=> Press 'C' to Create a New Comment");
        Console.WriteLine("Or Press any other key to go back to the post list...");
        ConsoleKey inputkey = Console.ReadKey(true).Key;
        if(inputkey == ConsoleKey.C)
        {
            Console.WriteLine("\nEnter the Content of the Comment:");
            var content = Console.ReadLine();

            using (var context = new AppDbContext()) 
            {
                var author = context.Users.SingleOrDefault(x => x.ID == UserID);
                if (author is not null)
                {
                    //Console.WriteLine(author.Comments.Count);
                    post.Comments.Add(
                        new Comment
                        {
                            CommentID = author.Comments.Count + 1,
                            Author = author,
                            AuthorID = author.ID,
                            Post = post,
                            PostID = post.PostID,
                            Content = content,
                            CreatedAt = DateTime.Now,
                        }
                    );
                    context.SaveChanges();
                    Console.WriteLine("Comment added successfully!");
                    Thread.Sleep(1500);
                    Console.Clear();
                }
            }
        }
        Console.ResetColor();
    }
    public static void CreatNewPost()
    {
        Console.Clear();
        //Screen to take input
        using(var context = new AppDbContext())
        {
            // Input for the Post entity
            Console.WriteLine("\nEnter the Title of the Post:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter the Content of the Post:");
            string content = Console.ReadLine();

            // Check if the author exists
            var author = context.Users.FirstOrDefault(u => u.ID == UserID);
            if (author == null)
            {
                Console.WriteLine("Author not found. Aborting...");
                return;
            }

            // Create a new Post object
            var newPost = new Post
            {
                PostID = context.Posts.Count()+ 1,
                Title = title,
                Content = content,
                CreatedAt = DateTime.Now,
                AuthorID = UserID,
                Author = author // Set the navigation property
            };

            // Add the post to the database
            context.Posts.Add(newPost);
            context.SaveChanges();

            Console.WriteLine("Post added successfully!");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
}