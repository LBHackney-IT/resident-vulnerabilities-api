using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResidentInformation = ResidentVulnerabilitiesApi.V1.Domain.ResidentInformation;
using ResidentInformationResponse = ResidentVulnerabilitiesApi.V1.Boundary.Responses.ResidentInformation;

namespace ResidentVulnerabilitiesApi.V1.Factories
{
    public static class ResponseFactory
    {
        public static ResidentInformationResponse ToResponse(this ResidentInformation domain)
        {
            return new ResidentInformationResponse
            {
                UPRN = domain.UPRN,
                HealthConditionOrDisability = domain.HealthConditionOrDisability,
                ReceivesCouncilTaxReduction = domain.ReceivesCouncilTaxReduction,
                AdultSocialCareCases = domain.AdultSocialCareCases,
                ChildrenSocialCareCases = domain.ChildrenSocialCareCases,
                LivingInTemporaryAccomadation = domain.LivingInTemporaryAccomadation,
                LowIncome = domain.LowIncome,
                ChildWithSEND = domain.ChildWithSEND,
                SingleParent = domain.SingleParent,
                LearningDisability  = domain.LearningDisability,
                DateCreated = domain.DateCreated
            };
        }
    }
}
