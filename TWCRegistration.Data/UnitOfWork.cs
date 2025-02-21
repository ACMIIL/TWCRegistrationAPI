using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWCRegistration.Data.Repository;

namespace TWCRegistration.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Global Variables
        public INomineeRepository NomineeRepository { get; set; }

        #endregion

        public UnitOfWork(INomineeRepository nomineeRepository)
        {
            NomineeRepository = nomineeRepository;
        }
      
    }
}
