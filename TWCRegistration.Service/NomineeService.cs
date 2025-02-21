using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWCRegistration.Core.Models.Individual;
using TWCRegistration.Data;

namespace TWCRegistration.Service
{
    public class NomineeService : INomineeService
    {
        #region Global Variable
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region constructor
        public NomineeService(IUnitOfWork UnitOfWork)
        {
           _unitOfWork = UnitOfWork;
        }
        #endregion

        #region Method
        public async Task<List<RelationshipModel>> GetRelationshipName()
        {
            return await _unitOfWork.NomineeRepository.GetRelationshipName();
        }

        public async Task<string> InsertORUpdateNominee(NomineeModel nomineeModel)
        {
            return await _unitOfWork.NomineeRepository.InsertORUpdateNominee(nomineeModel);
        }

        public async Task<string> InsertORUpdateNomineeGuardian(NomineeGuardianModel nomineeGuardianModel)
        {
            return await _unitOfWork.NomineeRepository.InsertORUpdateNomineeGuardian(nomineeGuardianModel);
        }

        #endregion
    }
}
