using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefolio.Configuration
{
    internal class IOptions
    {
    }

    public class MyAppSettings
    {
        public string? AllowedHosts { get; set; }
        public LogLevel LogLevel { get; set; }
    }

    public class MySecrets
    {
        public string? MyDbConnection { get; set; }
        public string? MyApiKey { get; set; }
    }

    public class MyController : ControllerBase
    {
        private readonly MyAppSettings _appSettings;
        private readonly MySecrets _secrets;

        public MyController(IOptions<MyAppSettings> appSettings, IOptions<MySecrets> secrets)
        {
            _appSettings = appSettings.Value;
            _secrets = secrets.Value;
        }

        public IActionResult MyAction()
        {
            // Use the configuration settings here...
            return Ok();
        }
    }
}
