using System;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using ResidentVulnerabilitiesApi.V1.UseCase.Interfaces;

namespace ResidentVulnerabilitiesApi.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v1/resident-vulnerabilities")]
    [Produces("application/json")]
    public class ResidentVulnerabilitiesController : Controller
    {
        private IGetResidentByUprnUseCase _useCase;

        public ResidentVulnerabilitiesController(IGetResidentByUprnUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpGet]
        [Route("{uprn}")]
        public IActionResult ViewRecord(string requestUprn)
        {
            try
            {

                var uprn = long.Parse(requestUprn);
                var response = _useCase.Execute(uprn);
                if (response == null)
                    return NotFound("No match found.");
                return Ok(_useCase.Execute(uprn));
            }
            catch (FormatException)
            {
                return BadRequest("Invalid UPRN format.");
            }
            catch (ArgumentNullException)
            {
                return BadRequest("Invalid UPRN format.");
            }
        }
    }
}
