using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWCRegistration.Core.Models.Individual;

namespace TWCRegistration.Data.Repository
{
    public interface INomineeRepository
    {
        Task<string> InsertORUpdateNominee(NomineeModel nomineeModel);
        Task<string> InsertORUpdateNomineeGuardian(NomineeGuardianModel nomineeGuardianModel);
        Task<List<RelationshipModel>> GetRelationshipName();
    }
}
