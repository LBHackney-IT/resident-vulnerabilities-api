using ResidentVulnerabilitiesApi.V1.Boundary.Responses;
using ResidentVulnerabilitiesApi.V1.Gateways;
using ResidentVulnerabilitiesApi.V1.UseCase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResidentVulnerabilitiesApi.V1.UseCase
{
    public class GetResidentByIdUseCase : IGetResidentByIdUseCase
    {
        // private IResidentVulnerabilitiesGateway _residentVulnerabilitieswGateway;
        // public GetResidentByIdUseCase(IResidentVulnerabilitiesGateway residentVulnerabilitiesGateway)
        // {
        //     _residentVulnerabilitieswGateway = residentVulnerabilitiesGateway;
        // }

        public ResidentInformation Execute(int id)
        {
            return new ResidentInformation();
        }
    }
}
