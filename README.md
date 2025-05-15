# Todo MVC App

## Overview
This is the **Todo MVC App**, a web application built with **ASP.NET Core MVC** and **C#**, styled with **Bootstrap**. It helps users organize and manage their daily tasks through an intuitive interface.

### Key Features:
- Add new to-do items with title, category, and priority.
- Mark tasks as completed or pending.
- Delete tasks permanently.
- Hide tasks from the main list and unhide them later.
- Filter and sort tasks by category and priority.
- Responsive UI for desktop and mobile using Bootstrap.

## Technology Stack
- **Programming Language:** C#
- **Framework:** ASP.NET Core MVC (.NET 7)
- **Frontend:** Razor Views with Bootstrap 5 for styling
- **Development Environment:** Visual Studio Code
- **Version Control:** Git and GitHub

## Getting Started

### Prerequisites
- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio Code](https://code.visualstudio.com/)
- Git (optional, for version control)

### Running the Application
1. Clone this repository:
git clone https://github.com/yourusername/TodoMvcApp.git

css
Copy
2. Navigate to the project directory:
cd TodoMvcApp

arduino
Copy
3. Restore dependencies and run the app:
dotnet run

css
Copy
4. Open your browser and go to:
http://localhost:5000

markdown
Copy

## Project Structure
- `/Controllers` - Contains MVC controllers handling routing and logic.
- `/Models` - Defines the data models like `TodoItem`.
- `/Views` - Contains Razor views for UI rendering.
- `/Services` - Business logic and in-memory data storage.
- `/wwwroot` - Static files such as CSS, JavaScript, and images.

## Future Improvements
- Persistent storage with a database (e.g., Entity Framework Core with SQL Server).
- User authentication and personalized task lists.
- More advanced filtering and search capabilities.
- Notifications and reminders.

## Author
Justin James Corral

---

Feel free to open issues or submit pull requests if you want to contribute!
