using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace VF.Store.Data.ADO
{
    public class VFStoreDataContextADO : IDisposable
    {
        private readonly SqlConnection _conn;

        public VFStoreDataContextADO()
        {
            var connString = ConfigurationManager.ConnectionStrings["StoreConn"].ConnectionString;
            _conn = new SqlConnection(connString);
            _conn.Open();
        }

        public void ExecutarComando(string sql)
        {
            var comando = new SqlCommand()
            {
                CommandText = sql,
                CommandType = CommandType.Text,
                Connection = _conn
            };

            comando.ExecuteNonQuery();
        }

        public SqlDataReader ExecutarDataReader(string query)
        {
            var command = new SqlCommand(query, _conn);
            return command.ExecuteReader();
        }

        public void Dispose()
        {
            if (_conn.State == ConnectionState.Open)
                _conn.Close();
        }
    }
}
