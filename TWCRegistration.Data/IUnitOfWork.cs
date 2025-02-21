using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWCRegistration.Data.Repository;

namespace TWCRegistration.Data
{
    public interface IUnitOfWork
    {
        INomineeRepository NomineeRepository { get; }
    }
}
