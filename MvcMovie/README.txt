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
