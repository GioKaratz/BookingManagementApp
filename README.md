# BookingManagementApp
Booking Management Application

The Booking Management Application is a web-based application designed to manage bookings. It allows users to create, view, update, and delete bookings, along with additional features such as validation and data persistence.

**Features**

Create new bookings with details such as first name, last name, family members, reservation date, arrival date, and departure date.
View a list of existing bookings with their relevant information.
Edit and update booking details as needed.
Delete bookings that are no longer required.
Validate user inputs to ensure data accuracy and consistency.
Store booking data in a database for persistent access.

**Technologies Used**

ASP.NET Core: The web framework used to develop the application.
Entity Framework Core: used to manage the database.
AutoMapper: Used for object-object mapping to simplify data manipulation.
HTML, CSS, and JavaScript: The frontend technologies for building the user interface.
SQL Server: The database engine used to store booking data

**Usage**

Open the application in your web browser.
Use the provided navigation to create, view, edit, or delete bookings.
Fill in the required details and submit the form for creating or updating bookings.
View the list of existing bookings and make changes as needed.
Take advantage of the validation to ensure accurate data entry.
Remember to log out and secure the application in production environments.

**How to use**  

Clone this repository to your local machine  
Set up the database connection:  
Edit the appsettings.json file located in the BookingManagementApp project to specify your SQL Server connection string  
To create and apply the initial database schema, run the following command in the BookingManagementApp project:  
dotnet Update - Database

**Contributions**

Contributions to the Booking Management Application are welcome. Feel free to submit issues, feature requests, or pull requests to improve the application.
