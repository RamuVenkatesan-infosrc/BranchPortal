BranchPortal – API with ASP.NET Core & PostgreSQL
This project is a simple Branch Management API built using:

ASP.NET Core Web API
Entity Framework Core (Code-First)
PostgreSQL

It supports basic CRUD operations (Create, Read, Update, Delete) for managing different branches.

🛠️ Tech Stack



Technology
Description



ASP.NET Core Web API
Backend framework


Entity Framework Core
ORM for database access (Code-First)


PostgreSQL
Relational Database


C#
Programming Language



📁 Project Structure
BranchPortal/│├── Controllers/│   └── BranchesController.cs    --> API endpoints│├── Model/│   └── Branch.cs                --> Branch entity│├── Data/│   └── ApplicationDbContext.cs  --> EF Core DB Context│├── Dto/│   ├── BranchDto.cs             --> DTO for creating│   └── UpdateBranchDto.cs       --> DTO for updating  

🧱 Database (Code-First + PostgreSQL)

The project uses Entity Framework Core Code-First.
Database is automatically created using migrations.
PostgreSQL is the target database engine.

🔌 Connection String (example in appsettings.json)
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=BranchDb;Username=postgres;Password=your_password"
}


🔁 API Endpoints



Method
Route
Description



GET
/api/branches
Get all branches


GET
/api/branches/{id}
Get branch by ID


POST
/api/branches
Add new branch


PUT
/api/branches/{id}
Update branch


DELETE
/api/branches/{id}
Delete branch



🆔 About GUID
This project uses GUID (Globally Unique Identifier) as the primary key for branches instead of simple integers.
What is GUID?
A GUID looks like: 3f2504e0-4f89-11d3-9a0c-0305e82c3301It is a 128-bit unique identifier used to avoid ID conflicts.Useful in distributed systems where unique IDs are required.
Why use it?

Makes records harder to guess or access by attackers.
Ensures unique IDs across systems or environments.

Example Usage:
To fetch a branch:GET /api/branches/3f2504e0-4f89-11d3-9a0c-0305e82c3301The API automatically maps this GUID to a specific branch in the database.

📦 Example Branch Object
{
  "name": "Main City Branch",
  "location": "123 Main St, Anytown",
  "contactNumber": "0401234567",
  "managerName": "Jane Doe"
}


🙌 Author
Your Name HereFeel free to contribute, suggest improvements, or ask questions!
 
