using TECHCOOL;

SQLet.ConnectSqlServer("master", "localhost");

//Console.Write("Enter database (no special chars): ");
//string? database = Console.ReadLine();
//Console.WriteLine($"Creating database {database}");
//SQLet.Execute($"CREATE DATABASE {database}");



Console.WriteLine("Welcome to SQL Server Console Manager");
Console.WriteLine("Press enter to create a new database");
Console.ReadKey();
Console.Write("Enter database (no special chars): ");
string? database = Console.ReadLine();
Console.WriteLine($"Creating database {database}");
Database.Execute($"CREATE DATABASE {database}");
Console.ReadLine();


Console.WriteLine("Press enter to create a new Login");
Console.ReadKey();
Console.Write("Enter Login Name: ");
string? loginName = Console.ReadLine();
Console.Write("Enter Login Password: ");
string? loginPassword = Console.ReadLine();
Database.Execute($"CREATE LOGIN {loginName} WITH PASSWORD {loginPassword}");


Console.WriteLine("Press enter to create a new User");
Console.ReadKey();
Console.Write("Enter Username: ");
string? username = Console.ReadLine();
//Console.Write("Enter User Password: ");
//string? userPassword = Console.ReadLine();
Database.Execute($"CREATE USER {username} FOR LOGIN {loginName}");




