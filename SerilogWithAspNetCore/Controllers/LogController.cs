using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace SerilogWithAspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogController : ControllerBase
    {
    

        [HttpGet(Name = "Test")]
        public string Get(string contactId)
        {

            Log.Error("Contact is", contactId);

            return null;
        }
    }
}