using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


//Construct the Builder
var configuration = new ConfigurationBuilder()
    .AddJsonFile("appConfig.json")
    .Build();

//Instantiate the Service collection
IServiceCollection services = new ServiceCollection();


//Build the service provider
var serviceProvider = services.BuildServiceProvider();

//Discover the services

