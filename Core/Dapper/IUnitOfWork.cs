using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dapper
{
    public interface IUnitOfWork
    {
        IDbTransactionHandle Begin(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted);


        void Commit();


        void Rollback();
    }
}
