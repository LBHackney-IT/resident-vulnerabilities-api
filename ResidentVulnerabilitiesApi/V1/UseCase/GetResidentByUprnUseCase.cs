using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResidentVulnerabilitiesApi.V1.Boundary.Responses;
using ResidentVulnerabilitiesApi.V1.Factories;
using ResidentVulnerabilitiesApi.V1.Gateways;
using ResidentVulnerabilitiesApi.V1.UseCase.Interfaces;
using ResidentInformation = ResidentVulnerabilitiesApi.V1.Domain.ResidentInformation;
using ResidentInformationResponse = ResidentVulnerabilitiesApi.V1.Boundary.Responses.ResidentInformation;

namespace ResidentVulnerabilitiesApi.V1.UseCase
{
    public class GetResidentByUprnUseCase : IGetResidentByUprnUseCase
    {
        private IResidentVulnerabilitiesGateway _residentVulnerabilitieswGateway;
        public GetResidentByUprnUseCase(IResidentVulnerabilitiesGateway residentVulnerabilitiesGateway)
        {
            _residentVulnerabilitieswGateway = residentVulnerabilitiesGateway;
        }

        public ResidentInformationResponse Execute(int uprn)
        {
            return _residentVulnerabilitieswGateway.GetResidentByUprn(uprn).ToResponse();
        }
    }
}
