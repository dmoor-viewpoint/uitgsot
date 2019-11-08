using LaunchDarkly.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LitterBug.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationController : ControllerBase
    {
        readonly LdClient _ldClient;

        public CalculationController(LdClient ldClient)
        {
            _ldClient = ldClient;
        }

        [HttpGet]
        public ActionResult<decimal> Get()
        {
            var user = LaunchDarkly.Client.User.Builder(Guid.NewGuid().ToString())
                                               .Name("Bob")
                                               .Custom("company", "generic company")
                                               .Build();
            bool showFeature = _ldClient.BoolVariation("api-call-test", user, false);
            if(showFeature)
            {
                return Ok(1);
            }
            
            return StatusCode(StatusCodes.Status401Unauthorized, 0);
        }
    }
}