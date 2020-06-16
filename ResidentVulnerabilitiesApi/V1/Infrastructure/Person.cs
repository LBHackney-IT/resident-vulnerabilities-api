using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResidentVulnerabilitiesApi.V1.Infrastructure
{
    [Table("example_table")]
    public class Person
    {
        [Column("id")] public int UPRN { get; set; }

        public bool HealthConditionOrDisability { get; set; }

        public bool ReceivesCouncilTaxReduction { get; set; }

        public int AdultSocialCareCases { get; set; }

        public int ChildrenSocialCareCases { get; set; }

        public int LivingInTemporaryAccomadation { get; set; }

        public bool LowIncome { get; set; }

        public bool ChildWithSEND { get; set; }

        public bool SingleParent { get; set; }

        public bool LearningDisability { get; set; }

        [Column("created_at")]
        public DateTime DateCreated { get; set; }

    }
}
