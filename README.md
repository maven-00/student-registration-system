<h1>Student Registration</h1>
<h3>Index</h3>
<h3>About the Project</h3>
    <p>This project is a backend system built using ASP.NET 6 and SQL Server. It handles CRUD operations for managing student data and integrates with a frontend interface. The API is secured using ...
    </p>
<h3>Technologies Used</h3>
    <ul>
        <li>ASP.NET 6</li>
        <li>SQL SERVER 2022 EXPRESS</li>
        <li>Entity Framework Core</li>
        <li>Swagger (For Testing Endpoints)</li>
        <li>Visual Studio 2022</li>
    </ul>
<h2>Getting Started</h2>
    <p>Follow these instructions to get the project up and running on your local machine.</p>
    <h3>Pre-requisites</h3>
        <ul>
            <li><a href="https://visualstudio.microsoft.com/vs/">Visual Studio 2022</a></li>
            <li><a href="https://dotnet.microsoft.com/en-us/download/dotnet/6.0">.NET 6 SDK</a></li>
            <li><a href="https://www.microsoft.com/en-us/sql-server/sql-server-downloads">SQL SERVER 2022 EXPRESS</a></li>
            <li><a href="https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16">SQL Server Management Studio 20.2</a></li>
        </ul>
    <h3>Installation</h3>
        <ol>
            <li>Clone the repository. You can create a new folder where you can easily access the file. Git Bash in your folder and run this code. <pre><code>git clone https://github.com/maven-00/student-registration-system.git 

cd your-folder</code></pre></li>
            <li>Open the file `StudentRegistration.sln` in Visual Studio.</li>
            <li>Restore the dependencies. <pre><code>dotnet restore</code></pre></li>
        </ol>
    <h2>Configuration</h2>
        <h3>Database Setup</h3>
        <p>Ensure the database is set up before running the project. Follow these steps for Entity Framework migrations:</p>
            <ol>
                <li>Open the Package Manager Console. Go to <b>Tools > NuGet Package Manager > Package Manager Console</b>.</li>
                <li>Add migration by running this command in the console.You can replace `InitialCreate` with your desired migration name.<pre><code>Add-Migration InitialCreate</code></pre></li>
                <li>Update the database by running this command.<pre><code>Update-Database</code></pre></li>
            </ol>
        <h3>Database Connection</h3>
        <p>Update your `appsettings.json` file with your SQL connection string. <pre><code>"ConnectionStrings": {
            "DefaultConnection": "Server=your-server-name;Database=your-database-name;User Id=your-username;Password=your-password;"
}</code></pre></p>
<h2>Running the Project</h2>
    <h3>Using Visual Studio 2022</h3>
    <ol>
        <li>Press `F5` to run the project in Debug mode.</li>
        <li>The project should start running, and Swagger documentation can be accessed at: <pre><code>http://localhost:5000/swagger</code></pre></li>
    </ol>
    <h3>Using CLI</h3>
    <pre><code>dotnet run</code></pre>
<h2>API Documentation</h2>
    <h3>Accessing the Swagger</h3>
    <pre><code>http://localhost:5000/swagger</code></pre>
    <h3>Sample API Endpoints</h3>
    <ul>
        <li>GET `/api/students` - Get all students.</li>
        <li>POST `/api/students` - Add a new student. </li>
        <li>PUT `/api/students/{id}` - Update student by Id</li>
        <li>DELETE `/api/students/{id}` - Delete student by Id</li>
    </ul>
<h2>Contributing</h2>
    <p>To contribute:</p>
    <ol>
        <li>Fork the repository.</li>
        <li>Create a new branch. <pre><code>git checkout -b feature/your-feature</code></pre></li>
        <li>Commit your changes. <pre><code>git commit -m 'Added a feature'</code></pre></li>
        <li>Push to the branch. <pre><code>git push origin feature/your-feature</code></pre></li>
        <li>Open a pull request.</li>
    </ol>
