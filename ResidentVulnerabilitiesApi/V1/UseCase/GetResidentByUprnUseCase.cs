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
        private IResidentVulnerabilitiesGateway _residentVulnerabilitiesGateway;
        public GetResidentByUprnUseCase(IResidentVulnerabilitiesGateway residentVulnerabilitiesGateway)
        {
            _residentVulnerabilitiesGateway = residentVulnerabilitiesGateway;
        }

        public ResidentInformation Execute(long uprn)
        {
            var residentInformation = _residentVulnerabilitiesGateway.GetResidentInformationByUPRN(uprn);

            return new Boundary.Responses.ResidentInformation
            {
                UPRN = residentInformation.UPRN,
                DateCreated = residentInformation.DateCreated,
                HealthConditionOrDisability = residentInformation.HealthConditionOrDisability,
                ReceivesCouncilTaxReduction = residentInformation.ReceivesCouncilTaxReduction,
                AdultSocialCareCases = residentInformation.AdultSocialCareCases,
                ChildSocialCareCases = residentInformation.ChildSocialCareCases,
                LivingInTemporaryAccommodation = residentInformation.LivingInTemporaryAccommodation,
                LowIncome = residentInformation.LowIncome,
                ChildWithSEND = residentInformation.ChildWithSEND,
                SingleParent = residentInformation.SingleParent,
                LearningDisability = residentInformation.LearningDisability
            };
        }
    }
}
