# AzureFunctionDependencyInjection

Azure Functions supports the dependency injection (DI) software design pattern, which is a technique to achieve Inversion of Control (IoC) between classes and their dependencies.
Azure Functions builds on top of the ASP.NET Core Dependency Injection features.

Support for dependency injection begins with Azure Functions 2.x.

Before you can use dependency injection, you must install the following NuGet packages:

 # Microsoft.Azure.Functions.Extensions

 # Microsoft.NET.Sdk.Functions package version 1.0.28 or later
  
 # Register services
  
  To register services, you can create a method to configure and add components to an IFunctionsHostBuilder instance. The Azure Functions host creates an instance of IFunctionsHostBuilder and passes it directly into your method.

To register the method, add the FunctionsStartup assembly attribute that specifies the type name used during startup. ASP.NET Core uses constructor injection to make your dependencies available to your function. The use of constructor injection means that you should not use static functions if you want to take advantage of dependency injection.
