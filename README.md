# CMPG-323-PROJECT-3-33301212
## Connected Office Web Application
The Connected Office Api is an Azure hosted application service that will be the used as a client interface between the user and the Connected Office Database.</br>
## Functions
Gives a user access to the database to be able to get, update, add or delete entries through http request methods.</br>
## Security
All database connections are stored securely in a secrets.json locally as to keep them off github and unaccessible via inspection. </br>
The program has authorization coded is that restricts access to the data pages if the user is not logged in.</br>
## Branching Strategy
This project makes use of a Main and a Developement Branch.</br>
A pull request to the main branch from the developement branch  only gets made once the code is running stable and has no identifiable bugs.</br>
## Endpoints</br>
### Direct Access
https://connectedofficewebapp.azurewebsites.net/</br>
## Steps to using the api
1. Open the provided link</br>
2. Go to Login</br>
3. Provide it with the applicable username and password</br>
4. After execution the Zone, Device and Category interfaces will become available.
## Program Layout
The program has been split into three projects each handeling a certain part of the application process.</br>
- ConnectedOffice is the main project and where the views and controllers are stored.</br>
- ConnectedOffice.Data is in charge of handeling operations between the database and the repositories.</br>
- ConnectedOffice.Service sits between the controllers and the repositories as a middle man.</br>
![alt text](https://imgur.com/yDPpmWe.png)</br>

