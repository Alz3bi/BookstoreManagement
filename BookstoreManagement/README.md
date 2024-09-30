# BookstoreManagement

## Setup Instructions

### Prerequisites
- .NET 7 SDK
- Visual Studio 2022 or later
- SQL Server (LocalDB or any other SQL Server instance)

### Steps to Set Up the Project

1. **Clone the Repository**
   - ```git clone https://github.com/Alz3bi/BookstoreManagement.git ```
   - ```cd BookstoreManagement```

2. **Open the Project in Visual Studio**
   - Open Visual Studio.
   - Select `File` > `Open` > `Project/Solution`.
   - Navigate to the cloned repository folder and select `BookstoreManagement.sln`.

3. **Restore NuGet Packages**
   - In Visual Studio, right-click on the solution in the Solution Explorer.
   - Select `Restore NuGet Packages`.

4. **Update the Database Connection String**
   - Open `appsettings.json`.
   - Update the `ConnectionStrings` section to point to your SQL Server instance.
   -```ConnectionStrings": {
   "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=BookstoreManagement;Trusted_Connection=True;MultipleActiveResultSets=true"
   }```

5. **Apply Migrations and Create the Database**
   - Open the Package Manager Console in Visual Studio (`Tools` > `NuGet Package Manager` > `Package Manager Console`).
   - Run the following commands:
   ```  Update-Database ```

### Running the Application

1. **Start the Application**
   - Press `F5` or click the `Start` button in Visual Studio to run the application.

2. **Access the Application**
   - Open a web browser and navigate to `https://localhost:5001` (or the URL specified in the launch settings).

### Using the CRUD Functionality

1. **Create a New Book**
   - Click on the `Create New` link on the Index page.
   - Fill in the book details and click `Create`.

2. **Read (View) Books**
   - The Index page lists all the books in the database.
   - Click on `Details` next to a book to view its details.

3. **Update a Book**
   - Click on `Edit` next to a book on the Index page.
   - Update the book details and click `Save`.

4. **Delete a Book**
   - Click on `Delete` next to a book on the Index page.
   - Confirm the deletion.

### Search Feature

- Use the search input field on the Index page to filter books by title or author.

## Additional Information

- This project uses ASP.NET Core MVC for the web application framework.
- Entity Framework Core is used for data access.
- The project targets .NET 7.
     