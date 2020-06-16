using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResidentVulnerabilitiesApi.V1.Infrastructure
{
    [Table("resident_vulnerabilities")]
    public class Person
    {
        [Column("uprn")]
        [MaxLength(16)]
        [Key]
        public int Id { get; set; }

        [Column("dateCreated")]
        public DateTime DateCreated { get; set; }

        [Column("healthConditionOrDisability")]
        public bool HealthConditionOrDisability { get; set; }

        [Column("receivesCouncilTaxReduction")]
        public bool ReceivesCouncilTaxReduction { get; set; }

        [Column("ascCases")]
        [MaxLength(10)]
        public int AscCases { get; set; }

        [Column("cscCases")]
        [MaxLength(10)]
        public int CscCases { get; set; }

        [Column("livingInTemporaryAccomodation")]
        public bool LivingInTemporaryAccommodation { get; set; }

        [Column("lowIncome")]
        public bool LowIncome { get; set; }

        [Column("childWithSEND")]
        public bool ChildWithSEND { get; set; }

        [Column("singleParent")]
        public bool SingleParent { get; set; }

        [Column("learningDisability")]
        public bool LearningDisability { get; set; }

    }
}
