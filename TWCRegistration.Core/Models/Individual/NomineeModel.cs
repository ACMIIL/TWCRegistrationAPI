using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWCRegistration.Core.Models.Individual
{
    public class NomineeModel
    {
      
            public Guid UserId { get; set; }
            public string NomineeFirstName { get; set; } = string.Empty;
            public string NomineeMiddleName { get; set; } = string.Empty;
            public string NomineeLastName { get; set; } = string.Empty;
            public string DOBNominee { get; set; } = string.Empty;
            public bool IsMinor { get; set; }
            public string PanNumber { get; set; } = string.Empty;
            public int RelationshipType { get; set; }
            public string FileName { get; set; } = string.Empty;
            public string FilePath { get; set; } = string.Empty;
        }

        public class NomineeGuardianModel
        {
            public Guid UserId { get; set; }
            public string GuardianFirstName { get; set; } = string.Empty;
            public string GuardianMiddleName { get; set; } = string.Empty;
            public string GuardianLastName { get; set; } = string.Empty;
            public string PanNumber { get; set; } = string.Empty;
            public int GuardianRelationshipType { get; set; }
            public string FileName { get; set; } = string.Empty;
            public string FilePath { get; set; } = string.Empty;
            public string DOB { get; set; } = string.Empty;
        }
        public class RelationshipModel
        {
            public int RelationId { get; set; }
            public string RelationName { get; set; }
        }
    
}
