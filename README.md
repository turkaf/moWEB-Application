# Movie Management Web Application

This web application allows users to view a movie database, add new movies, edit existing movies, and delete movies. Below are some general details about the project.

## Technologies

- **Frontend:** HTML, CSS, Bootstrap
- **Backend:** .NET Framework, MVC (Model-View-Controller) architecture
- **Database:** Microsoft SQL Server

## Features

- **Add Movie:** Users can add new movies from the management panel. Added movies are listed on the main screen as cards.
- **View Movie Details:** Each movie displayed on the main screen has a "Details" button. Clicking this button provides detailed information about the movie, including a trailer.
- **Edit Movie:** Each movie card has an "Edit" button. Clicking this button allows users to edit movie details.
- **Delete Movie:** Each movie card has a "Delete" button. Clicking this button removes the movie from the database.

## Installation

1. Copy the project files to your computer.
2. Use SQL Server Management Studio or a similar tool to run the `database.sql` file and create the database.
3. Open the `Web.config` file located in the project files and update the connection string in the `<connectionStrings>` section with your database connection information.
4. Open the project in Visual Studio or your preferred IDE.
5. Run the project to view the web application in your browser.

## Contributing

Contributions and suggestions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/new-feature`).
3. Make your changes.
4. Commit your changes (`git commit -am 'Add new feature'`).
5. Push to the branch (`git push origin feature/new-feature`).
6. Create a new Pull Request.

## License

No License
