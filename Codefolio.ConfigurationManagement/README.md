The configuration management project's purpose is to create a foundational layer to all further projects in the solution. It consists of the following:

Creational steps that show the process neccisary to set up a configuration file and build the appropriate services from it.
Once the services have been initialised, the following code can be activated along with the configuration to bootstrap the application from the top down.

A few project references have been added to the console application, specifically:
1. Microsoft.Extentions.DependancyInjection
2. Microsoft.Extentions.Http
3. Microsoft.Extentions.Configuration

These allow the creation and discovery of the services with a DI container.

