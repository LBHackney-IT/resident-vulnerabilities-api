using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResidentVulnerabilitiesApi.V1.Infrastructure
{
    [Table("example_entities")]
    public class Person
    {
        [Column("id")] public int Id { get; set; }

        [Column("created_at")] public DateTime CreatedAt { get; set; }

        [Column("full_name")]
        [MaxLength(62)]
        public string FullName { get; set; }

        [Column("title")]
        [MaxLength(8)]
        public string Title { get; set; }

        [Column("first_name")]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Column("last_name")]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Column("nhs_id")]
        [MaxLength(10)]
        public int NhsNumber { get; set; }

        [Column("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        [Column("gender")]
        [MaxLength(1)]
        public string Gender { get; set; }

        [Column("email_address")]
        [MaxLength(240)]
        public string EmailAddress { get; set; }

    }
}
