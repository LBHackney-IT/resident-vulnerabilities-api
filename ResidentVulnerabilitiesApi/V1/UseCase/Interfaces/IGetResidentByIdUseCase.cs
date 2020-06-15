using ResidentVulnerabilitiesApi.V1.Boundary.Responses;

namespace ResidentVulnerabilitiesApi.V1.UseCase.Interfaces
{
    public interface IGetResidentByIdUseCase
    {
        ResidentInformation Execute(int id);
    }
}
