2024-01-17
1830

Task 1

Successfully installed Visual Studio 2022 Community edition.
Created a web application by following the instructions.
Started the application without debugging.
	A welcome page opened in my web browser(Edge) with the URL - https://localhost:7063/
Completed Part 1.

Task 2

Added a controller as HelloWorldController1 with the code mentioned in the instructions.
Successfully able to display the output in the web browser that prints name and numtimes.

2024-01-18
1200

Task3
Modified the HelloWorldController class to use Razor view files and replaced the Index method with the mentioned code.
The code will calls the controller's View method.
Added a view by clicking on Views folder > Add > New Item.
Selected Razor View - Empty and named that as Index.cshtml.
Replaced the code in Index.cshtml with the given code.
Executed the code and able to see "Hello from our View Template!" which is hard-coded in the view.
Changed views and layout pages by selecting menu links MvcMovie, Home, and Privacy in _Layout.cshtml file.
Changed the title, footer, and menu link in the layout file.
Executed the code and able to see the changes in Privacy link.
In the Index.cshtml file and changed the title elements.

2024-01-18
1830

Passing Data from the Controller to the View
In the HelloWorldController did some changes in the welcome method that automatically maps the named parameters name and numTimes from the query string to parameters in the method.
Created a loop in the Welcome.cshtml view template that displays "Hello" NumTimes.
Saved all my changes and executed the code.
Data is taken from the URL and passed to the controller using the MVC model binder. The controller packages the data into a ViewData dictionary and passes that object to the view.


2024-01-20
2000

Task4

Added a file Movie.cs by Right-clicking the Models folder > Add > Class.
Updated Movies.cs file with the given code that adds ID, Title, ReleaseDate, Genre and Price.
Now adding NuGet packages.
Right-clickd on Controllers folder and select Add > New Scaffolded Item.
In the Dialog box selected Installed > Common > MVC
Selected MVC Controller with views, using Entity Framework.
In the Model class, Selected Movie (MvcMovie.Models).
Clicked plue icon in the DbContext class as selected MvcMovie.Data.MvcMovieContext.
I have selected SQL server as Database provider and selected add.
Tested the application and it was successful.

2024-01-24
2200

Task5
Work with a database in an ASP.NET Core MVC app

The MvcMovieContext is configured to connect to the database and map Movie objects to records, registered in the Dependency Injection container. 
The ASP.NET Core Configuration system reads the ConnectionString key, retrieved from the appsettings.json file for local development. 
To inspect the database, I use SQL Server Object Explorer (SSOX), right-clicked on the Movie table to view its structure in the Designer, noting the default primary key property named ID. 
Additionally, I explored the table data by right-clicking on the Movie table and selecting "View Data" in SSOX.

2024-01-28
2000

Task6
Controller methods and views

In the Movie app, some adjustments to the presentation are made in the Models/Movie.cs file, adding annotations such as [Display] and [DataType] to enhance field names like "Release Date" and specify data types. 
Additionally, a [Column(TypeName = "decimal(18, 2)")] annotation added to ensures proper mapping of Price to currency in the database through Entity Framework Core. 
The Movies controller utilizes Core MVC Anchor Tag Helpers to generate Edit, Details, and Delete links dynamically in the Views/Movies/Index.cshtml file.
Tag Helpers, allowing server-side code in Razor files, facilitate URL generation. 
In the Movies controller, the Edit actions, both HTTP GET and POST, handle movie editing and form submissions. 
The [Bind] attribute guards against over-posting, and the [ValidateAntiForgeryToken] attribute, paired with an anti-forgery token, prevents CSRF attacks. 
The HttpGet Edit method fetches movie details, and the associated view template specifies the expected model type. 
Various Tag Helpers streamline HTML markup for labels, input elements, and validation messages. 
Running the application and navigating to /Movies allows inspection of the generated HTML for the <form> element in the browser source.


2024-01-30
2200

Task7
Add search to an ASP.NET Core MVC app

In this section, the Movie app's Index action method in Controllers/MoviesController.cs is enhanced to incorporate search functionality by genre or name. 
The LINQ query for movie selection is modified conditionally based on the searchString parameter. 
The searchString, when containing a string, filters movies by title using a Lambda Expression in the LINQ query. 
The Index method can be configured to use the id parameter instead of searchString, allowing users to pass the search title as route data. 
However, to simplify user interaction, a <form> element is added to Views/Movies/Index.cshtml using the Form Tag Helper, enabling users to filter movies conveniently. 
The form specifies HTTP GET for capturing search information in the URL. 
To extend the search capability, a MovieGenreViewModel class is introduced in the Models folder, containing a list of movies, a SelectList of genres for user selection, MovieGenre for the selected genre, and SearchString for the entered text. 
The Index method in MoviesController.cs is updated to support search by genre. Finally, the Index.cshtml file in Views/Movies/ is adjusted to include search by genre, and a lambda expression in the HTML Helper is used to dynamically determine the display name for the Title property without causing access violations. 
The app is then tested for searching by genre, movie title, and a combination of both.

2024-01-31
2330

Task8
Add a new field to an ASP.NET Core MVC app

In this section, Entity Framework Code First Migrations is employed to add a new field, Rating, to the Movie model and synchronize it with the database. 
I have added Rating property to the Models/Movie.cs file, and the [Bind] attribute in both the Create and Edit action methods of MoviesController.cs is updated to include the new Rating property. 
View templates are modified to display, create, and edit the Rating field. 
The SeedData class is updated to provide a value for the new column in each Movie entry.

2024-02-01
0800

Task9
Add validation to an ASP.NET Core MVC app

In this section, validation logic is integrated into the Movie model to enforce rules whenever a user creates or edits a movie. 
I have added DataAnnotation namespace. Where DataAnnotations namespace offers built-in validation attributes like Required, StringLength, RegularExpression, Range, and DataType.
Added Range attribute which restricts values to within a specified range, and StringLength sets maximum and optional minimum lengths for string properties. 
Additionally, DataType attributes, such as DataType.Date and DataType.Currency, provide formatting hints to the view engine. 
When invalid data is submitted, both client-side and server-side validation errors are displayed, adhering to the DRY principle by defining validation rules once in the model class. 
The validation UI is automatically generated based on these rules, requiring no modifications to the controller or view templates. 
The ModelState.IsValid method evaluates validation attributes and returns true if the object has no validation errors, facilitating seamless form processing. 
By combining attributes on one line and leveraging DataType attributes for improved data formatting, the validation logic is streamlined and more efficient.

