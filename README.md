# 🐾 Fluffin Dugz Booking Page (C# – WinForms Project)

A Windows Forms application developed to manage customer grooming bookings for a pet business.  
The system connects to a MySQL database and demonstrates key programming concepts like **data validation, CRUD operations, and user interface design**.

---

## 🧠 Features
- Add, update, and delete pet grooming bookings  
- Store and retrieve data from a MySQL database  
- Clean, easy-to-use graphical interface  
- Data validation for booking details  
- Designed with scalability for future modules (e.g. reminders, reporting)

---

## 🧱 Technologies Used
- **Language:** C# (.NET Framework / Windows Forms)  
- **Database:** MySQL (phpMyAdmin)  
- **IDE:** Visual Studio 2022  
- **Concepts:** Object-Oriented Programming (OOP), CRUD Operations  

---

## 🚀 How to Run
1. Clone the repository  
   ```bash
   git clone https://github.com/kafeel2/FluffinDugzBookingPage.git

   2. Open the solution in Visual Studio 2022

   3.Update the connection string in your database class:

    MySqlConnection connect = new MySqlConnection("server=localhost;database=your_database;uid=your_username;pwd=your_password;");


   4.Build and run the project

   📂 Folder Structure
FluffinDugzBookingPage/
│
├── Classes/
│   ├── Booking.cs
│   ├── Customer.cs
│   └── DatabaseConnection.cs
│
├── Forms/
│   ├── BookingForm.cs
│   └── MainForm.cs
│
├── bin/
└── README.md

👤 Author

Kafeel Ahmed
Computer Science Student – University of the West of Scotland

This project was developed for educational purposes and can be extended with new modules such as authentication, notifications, and analytics.
