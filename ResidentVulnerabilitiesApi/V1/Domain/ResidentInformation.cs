using System;

namespace ResidentVulnerabilitiesApi.V1.Domain
{
    public class ResidentInformation
    {
        public string UPRN { get; set; }
        public bool HealthConditionOrDisability { get; set; }

        public bool ReceivesCouncilTaxReduction { get; set; }

        public int AdultSocialCareCases { get; set; }

        public int ChildrenSocialCareCases { get; set; }

        public int LivingInTemporaryAccomadation { get; set; }

        public bool LowIncome { get; set; }

        public bool ChildWithSEND { get; set; }

        public bool SingleParent { get; set; }

        public bool LearningDisability { get; set; }

        public string DateCreated { get; set; }
    }
}
