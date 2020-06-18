using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTestCICD.Contracts
{
    public interface IRepositoryWrapper
    {
        IOwnerRepository Owner { get; }
        //IAccountRepository Account { get; }
        void Save();
    }
}
