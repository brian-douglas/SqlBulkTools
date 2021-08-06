using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace SqlBulkTools
{
    internal interface ITransaction
    {
        int Commit(IDbConnection connection);

        int Commit(SqlConnection connection);

        Task<int> CommitAsync(SqlConnection connection);
    }
}