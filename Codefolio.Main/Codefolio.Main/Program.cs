﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Text.Json;
using Codefolio.Configuration;

var configuration = new ConfigurationBuilder()
.AddJsonFile("appsettings.json", false)
.AddUserSecrets(typeof(Program).Assembly, false)
.Build();

IServiceCollection services = new ServiceCollection();

services.AddOptions<MyAppSettings>().Bind(configuration.GetRequiredSection("customSettings"));



var serviceProvider = services.BuildServiceProvider();

Console.Read();
