# Driving License Management System

[![.NET Framework](https://img.shields.io/badge/.NET-Framework-blue)](https://dotnet.microsoft.com/en-us/download/dotnet-framework)  
[![C#](https://img.shields.io/badge/language-C%23-blue)](https://docs.microsoft.com/en-us/dotnet/csharp/)  
[![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-green)](https://www.microsoft.com/en-us/sql-server)

---

A desktop application for managing driving licenses, developed using C# with a SQL Server database.

---

## 🚀 Requirements

- **Operating System:** Windows  
- **SQL Server:** Any edition including SQL Server Express (SQL Server 2022 used in development environment)  
- **Visual Studio:** 2022 or later  
- **.NET Framework:** 4.7.2 or higher  

---

## 🛠️ Installation & Running Instructions

1. **Download the project:**  
   - From GitHub: [Download ZIP] or clone the repository using `git clone`

2. **Import the database:**  
   - To use the script, open SQL Server Management Studio (SSMS) and run the `DVLD_script.sql` file in a new database.  
   - Alternatively, restore the database using the `DVLD.bak` backup file via SQL Server.

3. **Configure database connection:**  
   - Open `App.config` or `Settings.cs` file.  
   - Update the `ConnectionString` to match your server name and database.

4. **Run the application:**  
   - Open the solution in Visual Studio.  
   - Press `Start` to launch the program.

---

## 💡 Important Notes

- On the first run, you need to manually add user credentials.  
- If user info is missing, the program will throw an error on startup.  
- To avoid this, please ensure you add the following default credentials for login:  
  - **Username:** `admin`  
  - **Password:** `admin`

---

## 🤝 Contribution

Contributions, suggestions, and improvements are welcome. Feel free to open a Pull Request.

---

## 📬 Contact

If you have any questions or need support, you can reach out via:  
- GitHub Issues  
- Email: sellama.malek.dev@gmail.com

---
