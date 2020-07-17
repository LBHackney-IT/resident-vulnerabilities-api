using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResidentVulnerabilitiesApi.V1.Infrastructure
{
    [Table("qlik_vulnerability")]
    public class Resident
    {
        [Column("uprn")]
        [MaxLength(20)]
        [Key]
        public long UPRN { get; set; }

        [Column("date_created")]
        public DateTime DateCreated { get; set; }

        [Column("health_condition_or_disability")]
        public bool HealthConditionOrDisability { get; set; }

        [Column("receives_council_tax_support")]
        public bool ReceivesCouncilTaxReduction { get; set; }

        [Column("asc_cases")]
        [MaxLength(10)]
        public int AdultSocialCareCases { get; set; }

        [Column("csc_cases")]
        [MaxLength(10)]
        public int ChildSocialCareCases { get; set; }

        [Column("living_in_temporary_accomodation")]
        public bool LivingInTemporaryAccommodation { get; set; }

        [Column("low_income")]
        public bool LowIncome { get; set; }

        [Column("child_with_send")]
        public bool ChildWithSEND { get; set; }

        [Column("single_parent")]
        public bool SingleParent { get; set; }

        [Column("learning_disability")]
        public bool LearningDisability { get; set; }

    }
}
