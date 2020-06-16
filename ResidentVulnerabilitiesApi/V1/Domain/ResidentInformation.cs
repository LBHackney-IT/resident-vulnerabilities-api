using System;

namespace ResidentVulnerabilitiesApi.V1.Domain
{
    public class ResidentInformation
    {
        public int UPRN { get; set; }
        public DateTime DateCreated { get; set; }
        public bool HealthConditionOrDisability { get; set; }
        public bool ReceivesCouncilTaxReduction { get; set; }
        public int AdultSocialCareCases { get; set; }
        public int ChildSocialCareCases { get; set; }
        public bool LivingInTemporaryAccommodation { get; set; }
        public bool LowIncome { get; set; }
        public bool ChildWithSEND { get; set; }
        public bool SingleParent { get; set; }
        public bool LearningDisability { get; set; }
    }
}
