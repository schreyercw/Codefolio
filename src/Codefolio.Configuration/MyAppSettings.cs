using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefolio.Configuration
{
    public class MyAppSettings
    {
        public MySecrets MySecrets { get; set; }
    }

    public class MySecrets
    {
        public string? MyDbConnection { get; set; }
        public string? MyApiKey { get; set; }
    }
}
