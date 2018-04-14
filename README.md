# Assignment2WebAPIs
.Net core WebApi Project for assignment2

This Project concludes API for Create-Read-Update-Delete Operations For Screens and Theaters Tables Used in 
Assignment 2 Part1.

Complete Documentaion Using Swagger in .net core is available on below link - 
http://assignment2webapi.azurewebsites.net/swagger/

Screens API
1. /api/Screens - Get All Screens {GET}
2. /api/Screens - Add New Screen {POST}
3. /api/Screens/{id} - Get One Screen Details {GET} 
4. /api/Screens/{id} - TO Update One Screen Details {PUT}
5. /api/Screens/{id} - To Delete A Screen By ID {Delete}

Theaters API
1. /api/Theaters - Get ALl Theaters {get}
2. /api/Theaters - Post / Save a Theater to add new theater {POST}
3. /api/Theaters{id} - Get One Theater Details {GET}
4. /api/Theaters{id} - To Update Theater Details By Theater ID {PUT}
5. /api/Theaters{id} - TO Delete a Theater Record {Delete}

Advanced .Net Core Feature
1. We Have used Swagger Extention available in .net Core that can provide documentation for our .net core webapi project
2. I have used .net core async actions that are one of core feature of .net core fast performance
3. We have resolved errors coming in generating strongly typed scafflod controller of webapi with read / write actions using entity framework.

