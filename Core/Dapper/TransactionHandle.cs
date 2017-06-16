using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dapper
{
    class TransactionHandle : IDbTransactionHandle
    {
        private IDbTransaction transaction;

        /// <summary>
        /// Triggered after Dispose is called
        /// </summary>
        public event EventHandler<EventArgs> Disposed;


        public IsolationLevel IsolationLevel { get; private set; }

        public TransactionHandle(IDbTransaction transaction)
        {
            this.transaction = transaction;
            IsolationLevel = transaction.IsolationLevel;
        }

        public void Dispose()
        {
            if (transaction != null)
            {
                transaction.Commit();
                transaction.Dispose();

                OnDisposed();

                transaction = null;
            }
        }

        protected virtual void OnDisposed()
        {
            var handler = Disposed;
            if (handler != null) handler(this, EventArgs.Empty);
        }
    }
}
