# lh-pets

`LH Pets` is a basic web project developed in C# using ASP.NET Core. This project serves as a simple application to demonstrate route mapping and HTTP response handling. It includes features like redirecting to a static HTML file and displaying a list of clients from a database.

## Features

- **Root Route**: Displays a welcome message `"Projeto Web - LH Pets"` at the root (`/`) of the site.
- **Static Files**: Serves static files, such as HTML, CSS, and JavaScript, from the default directory.
- **Redirection**: Redirects the `/index` route to the `index.html` file.
- **Client Listing**: Provides a list of clients as a string at the `/listaClientes` route.

## How to Run

1. **Prerequisites**:
   - .NET SDK 6.0 or higher installed.

2. **Running the Application**:
   - Navigate to the project directory and run:
     ```bash
     dotnet run
     ```
   - The application will start and be available at `http://localhost:[PORT]`, where `[PORT]` is the port automatically assigned by .NET or specified by the user.

3. **Testing the Routes**:
   - Access `http://localhost:[PORT]/` to see the welcome message.
   - Access `http://localhost:[PORT]/index` to be redirected to `index.html`.
   - Access `http://localhost:[PORT]/listaClientes` to view the list of clients.

## Contribution

Feel free to open issues or submit pull requests. All contributions are welcome!

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.