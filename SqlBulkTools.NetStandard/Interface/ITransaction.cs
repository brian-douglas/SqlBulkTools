using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace SqlBulkTools
{
    internal interface ITransaction
    {
        int Commit(IDbConnection connection, SqlTransaction transaction);

        int Commit(SqlConnection connection, SqlTransaction transaction);

        Task<int> CommitAsync(SqlConnection connection, SqlTransaction transaction);
    }
}