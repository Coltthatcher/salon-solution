#### Created By _**Colton Thatcher**_

#### _SillyBand Factory_

## Technologies Used


* _C#_
* _.NET 5_
* _ASP.NET Core MVC_
* _dotnet script, REPL_
* _Razor View Engine_
* _MySQL and MySQL Workbench_
* _GIT_


## Description

_Project using MVC routing, DataBases to replicate a factory setting in which Engineers work on machines_

## Setup/Installation Requirements
* _Install .NET 5.0 [Here](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)_
* _Clone the GitHub [repository]() or download and open the Zip on your local machine._
* _inside Git or Terminal navigate to the project directory using `cd SillyStringzFactory.Solution`._
* _Then you will want to be in the root project folder so `cd Factory` in Git or Terminal._
* _Create an `appsettings.json` file in the folder listed above by typing `touch appsettings.json`._
* _Add the code listed below to your `appsettings.json` file._
* _{
"ConnectionStrings": {
"DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE];uid=root;pwd=[YOUR PASSWORD];"
}
}_
* _Note `[YOUR DATABASE]` and `[YOUR PASSWORD]` are the same as your personal database._
* _Open `localhost5000` in the terminal to view and use the website._

## Setting Up A Database

* _You will need to download MySQL and MySql Workbench to create a database._
* _After you have installed MySQL Workbench open it and a local server._
* _The Navigator box on the left includes an Administration tab, open it and Choose to Select Data/Import restore._
* _In the category import options choose import from Self-Contained File, and then select `colt_thatcher_factory.sql` this file is located in `SillyStringzFactory.Solution`._
* _Select New in the default schema option._
* _Enter a database name and confirm._
* _Start import to begin importing your database._

## Running the website

* _Go to the Factory Root folder with the command `cd Factory` in Git or Terminal._
* _You will need to run `dotnet restore` in the file above to add bin/obj files which are required for your program to run correctly._
* _The last step to see the website running is `dotnet run` in Git or terminal (you will still be in the root directory), you will need to follow the link provided by `localhost:5000` to see the website._




## Known Bugs

_Currently there is zero functionality because I installed the wrong version of dotnet ef globally and cannot uninstall._

## Future Updates

* _Hopefully Functionality can be added to the site._

## License

_[MIT](https://opensource.org/licenses/MIT)_
Copyright (c) _2021_ _Colt Thatcher_

## Support and Contact Details
* _[colt.thatcher303@gmail.com](colt.thatcher303@gmail.com)_

