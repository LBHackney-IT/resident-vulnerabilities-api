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
        [Route("{requestUprn}")]
        public IActionResult ViewRecord(long requestUprn)
        {
            var response = _useCase.Execute(requestUprn);
            if (response == null)
                return NotFound("No match found.");
            return Ok(response);
        }
    }
}
