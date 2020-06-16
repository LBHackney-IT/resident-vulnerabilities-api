using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResidentVulnerabilitiesApi.V1.Boundary.Responses
{
    public class ResidentInformation
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public bool HealthConditionOrDisability { get; set; }
        public bool ReceivesCouncilTaxReduction { get; set; }
        public int AscCases { get; set; }
        public int CscCases { get; set; }
        public bool LivingInTemporaryAccommodation { get; set; }
        public bool LowIncome { get; set; }
        public bool ChildWithSEND { get; set; }
        public bool SingleParent { get; set; }
        public bool LearningDisability { get; set; }
    }
}
