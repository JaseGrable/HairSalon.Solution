# Eau Claire's Salon

#### By Jase Grable

## Technologies Used

- C#
- Entity Framework Core
- MySQL Workbench
- Razor
- ASP.NET Core MVC
- VS Code
- .NET6
- Command Line

## Description

The application allows a user to create, edit, and delete both clients and stylists. Clients are linked to a stylist using a one to many database relationship. This was built for Epicodus Bootcamp week 10.

## Setup Instructions

1. Open your shell of choice (e.g., Terminal or GitBash) and run these commands:
2. Clone the project using
   `$ git clone https://github.com/JaseGrable/HairSalon.Solution.git`
3. Navigate to the root directory (HairSalon.Solution)
4. Run `$ touch .gitignore`
5. Copy/paste this into the .gitignore file:
   obj
   bin
   appsettings.json

### Importing the MySQL Database:

- Open MySQL Workbench, in the Navigator > Administration window, select Data Import/Restore.
- In Import Options select Import from Self-Contained File.
- Navigate to the sql file located in the root directory of this project called jase_grable.sql
- Under Default Schema to be Imported To, select the New button.
- Choose a name for your database, or use jase_grable.sql and
- Click OK
- Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.
- After you are finished with the above steps, reopen the Navigator > Schemas tab.
- Right click and select Refresh All.

6. Navigate to this project's production directory (HairSalon) using `$ cd HairSalon`.
7. Within the production directory create a new file called appsettings.json.
8. In appsettings.json, paste in the following code, replacing your_database, user-id, and password values with your newly created database name, own username and password for MySQL (remove square brackets when inputting your details):
   `{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[your_database];uid=[user-id];pwd=[password];"
  }
}`
9. Within the production directory (HairSalon), run `dotnet watch run`to start the application in development mode with a watcher.

## Known Bugs

None

## License

MIT Copyright (c) 2023 Jase Grable
