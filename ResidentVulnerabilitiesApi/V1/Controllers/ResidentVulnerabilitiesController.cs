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
        private IGetResidentByUprnUseCase _getResidentByIdUseCase;

        public ResidentVulnerabilitiesController(IGetResidentByUprnUseCase getResidentByIdUseCase)
        {
            _getResidentByIdUseCase = getResidentByIdUseCase;
        }

        [HttpGet]
        [Route("{uprn}")]
        public IActionResult ViewRecord(int uprn)
        {
            return Ok(_getResidentByIdUseCase.Execute(uprn));
        }

    }
}
