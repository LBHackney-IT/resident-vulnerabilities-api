using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResidentVulnerabilitiesApi.V1.Boundary.Responses;
using ResidentVulnerabilitiesApi.V1.Gateways;
using ResidentVulnerabilitiesApi.V1.UseCase.Interfaces;


namespace ResidentVulnerabilitiesApi.V1.UseCase
{
    public class GetResidentByUprnUseCase : IGetResidentByUprnUseCase
    {
        private IResidentVulnerabilitiesGateway _residentVulnerabilitieswGateway;
        public GetResidentByUprnUseCase(IResidentVulnerabilitiesGateway residentVulnerabilitiesGateway)
        {
            _residentVulnerabilitieswGateway = residentVulnerabilitiesGateway;
        }

        public ResidentInformation Execute(int uprn)
        {
            return new ResidentInformation();
        }
    }
}
