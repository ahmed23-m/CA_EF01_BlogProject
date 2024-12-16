# Blog Project  

A full-stack blogging application built with **C#**, **Entity Framework Core**, **.NET**, and **MS SQL Server**. This project implements key blogging functionalities such as user authentication, post creation, comment management, and a paginated feed for posts.  

## 🚀 Features  
- **Login & Registration**: Secure user authentication system.  
- **Posts Feed with Pagination**: Efficiently browse posts with pagination for better performance.  
- **Create a New Post**: Share your thoughts by creating engaging blog posts.  
- **Add Comments**: Engage with posts by leaving comments.  

## 🛠️ Technologies Used  
- **C#**  
- **Entity Framework Core**  
- **.NET**  
- **LINQ**  
- **MS SQL Server**  

## 📂 Project Structure  
```
BlogProject/  
├── Controllers/        # Handles HTTP requests  
├── Models/             # Data models for the application  
├── Views/              # User interface components  
├── Data/               # Database context and migrations  
├── wwwroot/            # Static files (CSS, JS, etc.)  
└── Program.cs          # Application entry point  
```  

## ⚙️ Setup and Installation  

1. Clone the repository:  
   ```bash
   git clone https://github.com/yourusername/blog-project.git
   cd blog-project
   ```  

2. Install the required dependencies:  
   - Ensure you have **.NET SDK** installed.  
   - Install dependencies using `dotnet restore`.  

3. Configure the database:  
   - Update the connection string in `appsettings.json` to point to your MS SQL Server instance.  
   - Run migrations to set up the database:  
     ```bash
     dotnet ef database update
     ```  

4. Run the application:  
   ```bash
   dotnet run
   ```  

5. Access the application in your browser:  
   Navigate to `http://localhost:5000`.  

## 🌟 Contributing  
Contributions are welcome! If you have ideas for improvements or new features, feel free to fork the repository and create a pull request.  

## 📜 License  
This project is licensed under the MIT License. See the `LICENSE` file for details.  

## 🙌 Acknowledgments  
Special thanks to the amazing .NET community for providing excellent resources and support!  

---  

Feel free to update the placeholder values (like the repository URL or your username) before adding this to your GitHub repository. Let me know if you need help with anything else!
