# 📚 Matesoft Library 3.0

**Matesoft Library 3.0** is a professional **C# Windows Forms Application** designed to manage library operations such as book inventory, member registration, borrowing and returning of books — all handled via a smooth desktop interface.

---

## 🖥️ Built With

- **C# (.NET Framework)** – Windows Forms (WinForms)
- **MySQL** – Database
- **HTML** – Help files, external templates (minor)
- **Database** stored inside project folder (`database/`)

---

## 📂 Project Structure

```
/ (root)
├── bin/                  # Compiled binaries (Debug / Release)
├── database/             # Database backup (.sql) for import
├── MatesoftLibrary/      # Main application source code
│   ├── Forms/            # Windows Forms (UI pages like Books, Members, Settings)
│   ├── Properties/       # Project properties and settings
│   ├── Resources/        # Icons, Images, Logos used in application
│   └── App.config        # Application configuration (Connection Strings)
├── obj/                  # Temporary build files
├── MatesoftLibrary.sln   # Visual Studio Solution File
├── README.md             # You are here!
```

---

## 📦 Installation Instructions

1. **Clone the repository:**
   ```bash
   git clone https://github.com/PamudithaPerera/Matesoft-Library-3.0.git
   ```

2. **Setup Database:**
   - Open your localhost server (e.g., XAMPP / WAMP / Laragon).
   - Open **phpMyAdmin**.
   - Create a new database named:
     ```
     dblibrary
     ```
   - Import the `.sql` file from the `/database/` folder into `dblibrary`.

3. **Configure Database Connection:**
   - Open the project in **Visual Studio**.
   - Open `App.config`.
   - Update the connection string if necessary:
     ```xml
     <connectionStrings>
         <add name="LibraryDB" connectionString="server=localhost;user id=root;password=;database=dblibrary" providerName="MySql.Data.MySqlClient" />
     </connectionStrings>
     ```

4. **Run the Project:**
   - Set `MatesoftLibrary` as the Startup Project.
   - Build and Run (F5).

5. **Login and Enjoy!**

---

## 🛠️ Key Features

- 📚 **Book Management:** Add, edit, delete, view book records
- 👤 **Member Management:** Register, update, manage library members
- 📖 **Borrow and Return Books:** Track lending activities
- 🔒 **Admin Login:** Secure authentication for system access
- 📈 **Reports:** View transaction histories and borrowing reports
- 🖼️ **Modern UI:** Icons, Images, and easy navigation
- ⚡ **Fast Performance:** Optimized Windows Forms application

---

## 🔐 Default Admin Credentials

| Username | Password |
|:--------:|:--------:|
| librarian    | librarian |

> (You should change the default password after first login for security.)

---

## ⚙️ Requirements

- Windows 7/8/10/11
- Visual Studio 2019 or later
- .NET Framework 4.7.2 or higher
- MySQL Server / MariaDB

---

## 📞 Contact

- **Developer:** Pamuditha Perera
- **GitHub:** [@PamudithaPerera](https://github.com/PamudithaPerera)

