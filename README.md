# DaddyJokesWebApp
This is a test demo application used to get random joke and joke count from DaddyJokes.io api.
This demo has the normal asp.net core mvc architectural format.
It has filters been used to handle exception been occured.
Service class which basically has the GetJoke<T> Generic method to call both the DaddyJokes.io endpoints.
The service class has been registered as dependency injection in configure services method of Startup class
UI is been handled using normal MVC, have created two Pages one is RandomJoke and other one is RandomJokeCount.
Models are RandomJoke and RandomJokeCount.
