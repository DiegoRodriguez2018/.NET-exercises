### Description
This is just a collection of .NET exercises I have done and also some quick notes I have written. 


### Console Applications

To create a new console app:
`dotnet new console -o myApp`

Note that -o flag indicates in what folder the app is going to be created, and the console refers to the console app template. To see more options type:

`dotnet new --help`



---
Remember to import `System.Collections.Generic` if List are going to be implemented in the program:
```C#
using System.Collections.Generic;
```

---
### Web Applications
To create an empty web application:
`dotnet new web -o myApp`

To run application in server:
`dotnet run`


---
### MVC Application
To create a MVC (Model View Controller) application, first create a folder were the project is going to be stored, and then inside this folder run:

To create an empty web application:
`dotnet new mvc -au None`

Note that -au refers to authentication and the options are:

* None - No authentication (Default).
* IndividualB2C - Individual authentication with Azure AD B2C.
* SingleOrg - Organizational authentication for a single tenant.
* Windows - Windows authentication.

To run application in server:
`dotnet run`




