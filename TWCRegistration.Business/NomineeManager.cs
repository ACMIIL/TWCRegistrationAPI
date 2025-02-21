using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWCRegistration.Core.Models.Individual;
using TWCRegistration.Service;

namespace TWCRegistration.Business
{
    public class NomineeManager : INomineeManager
    {
        #region Global Variable
        private readonly INomineeService _service;
  
        #endregion

        #region Ctor
        public NomineeManager(INomineeService service)
        {
           _service = service;
        }
        #endregion

        #region Method
        public async Task<List<RelationshipModel>> GetRelationshipName()
        {
            return await _service.GetRelationshipName();
        }

        public async Task<string> InsertORUpdateNominee(NomineeModel nomineeModel)
        {
            return await _service.InsertORUpdateNominee(nomineeModel);
        }

        public async Task<string> InsertORUpdateNomineeGuardian(NomineeGuardianModel nomineeGuardianModel)
        {
            return await _service.InsertORUpdateNomineeGuardian(nomineeGuardianModel);
        }

        #endregion
    }
}
