using ResidentVulnerabilitiesApi.V1.Boundary.Responses;
using ResidentInformationResponse = ResidentVulnerabilitiesApi.V1.Boundary.Responses.ResidentInformation;

namespace ResidentVulnerabilitiesApi.V1.UseCase.Interfaces
{
    public interface IGetResidentByUprnUseCase
    {
        ResidentInformationResponse Execute(int uprn);
    }
}
