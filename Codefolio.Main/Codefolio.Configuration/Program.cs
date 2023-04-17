using Microsoft.Extensions.Configuration;
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

var myAppSettingsOptions = new OptionsWrapper<MyAppSettings>(new MyAppSettings());

configuration.Bind(myAppSettingsOptions.Value);
var myAppSettings = myAppSettingsOptions.Value;

Console.WriteLine(myAppSettings.MySecrets.MyDbConnection);
Console.WriteLine(configuration["MySecrets:MyDbConnection"]);

Console.Read();
