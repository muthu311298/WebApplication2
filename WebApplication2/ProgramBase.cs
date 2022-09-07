using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class ProgramBase
    {
        public static Task<IActionResult> Run(HttpRequest req, Microsoft.Extensions.Logging.ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            return null;
        }
    }
}