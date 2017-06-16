using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ConnectionFactory
    {
        private readonly DbProviderFactory _providerFactory;
        private readonly string _connectionString;

        public ConnectionFactory(ConnectionStringSettings settings)
        {
            _providerFactory = DbProviderFactories.GetFactory(settings.ProviderName);
            _connectionString = settings.ConnectionString;
        }

        public IDbConnection Create()
        {
            var connection = _providerFactory.CreateConnection();
            connection.ConnectionString = _connectionString;
            return connection;
        }
    }
}
