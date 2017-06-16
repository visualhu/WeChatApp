using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dapper
{
    public interface IDbTransactionHandle : IDisposable
    {
        /// <summary>
        /// Triggered after Dispose is called
        /// </summary>
        event EventHandler<EventArgs> Disposed;

        /// <summary>
        /// Gets the isolation level
        /// </summary>
        IsolationLevel IsolationLevel { get; }
    }
}
