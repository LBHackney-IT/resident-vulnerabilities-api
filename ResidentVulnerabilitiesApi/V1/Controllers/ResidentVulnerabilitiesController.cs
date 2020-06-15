using System;
using System.Collections.Generic;
using ResidentVulnerabilitiesApi.V1.UseCase.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ResidentVulnerabilitiesApi.V1.Boundary.Responses;
using System.Reflection.Metadata.Ecma335;

namespace ResidentVulnerabilitiesApi.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v1/residents")]
    [Produces("application/json")]
    public class ResidentVulnerabilitiesController : Controller
    {
        private IGetResidentByIdUseCase _getResidentByIdUseCase;

        public ResidentVulnerabilitiesController(IGetResidentByIdUseCase getResidentByIdUseCase)
        {
            _getResidentByIdUseCase = getResidentByIdUseCase;
        }

        [HttpGet]
        public IActionResult ListContacts()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{academyId}")]
        public IActionResult ViewRecord(int academyId)
        {
            return Ok(_getResidentByIdUseCase.Execute(academyId));
        }

    }
}
