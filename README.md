
# LibrarySystem_OOP_CSharp

A simple Library Management System built using C# and Object-Oriented Programming (OOP) principles.  
This project allows users to manage books and members, perform borrowing and returning operations, and display library data.

# Demo
<img width="1170" height="277" alt="Screenshot 2025-08-12 124300" src="https://github.com/user-attachments/assets/90cc1432-cb87-4746-abef-6bcd4ef88a71" />

## 📚 Features

- Add and list books
- Add and list library members
- Borrow a book (only if it's available)
- Return a borrowed book
- Show a member's borrowed books

## 🛠️ Technologies Used

- C#
- .NET Console Application
- Object-Oriented Programming (OOP)

## 🧱 Project Structure

- `Book`: Class representing a book (ID, Title, Author, IsAvailable)
- `AbstractPerson`: Abstract class for library members
- `Member`: Inherits from `AbstractPerson`, can borrow and return books
- `Library`: Manages books and members (add, find, display)
- `Program.cs`: Contains the main menu and handles user input

## 🚀 How to Run

1. Open the project in Visual Studio or any C# IDE
2. Build the solution
3. Run the application
4. Use the interactive console menu to manage books and members
