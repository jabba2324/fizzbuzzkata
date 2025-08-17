# Fizz Buzz API Kata
This is a C# API for FizzBuzz, it has a single GET endpoint at /api/FizzBuzz/{number} this project demonstrates use of dependency injection, swagger and TDD in .NET 8 with ASP.NET Core

More on FizzBuzz [here](http://wiki.c2.com/?FizzBuzzTest).

## Building
To build the project

```console
dotnet build
``` 
in the root directory

## Running
To run the project:

```console
dotnet run
```
in ```\FizzBuzz```

By default the root directory should load a nice swagger doc detailing the endpoint for FIzzBuzz, the default server configuration will listen to http://localhost:5000 (HTTP) and https://localhost:5001 (HTTPS) 

## Testing

To run tests:

```console 
dotnet watch test
``` 
in ```\FizzBuzzTests```
