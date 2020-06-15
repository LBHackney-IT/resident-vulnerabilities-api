using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResidentVulnerabilitiesApi.V1.Boundary.Responses
{
    public class ResidentInformation
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
    }
}
