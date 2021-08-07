using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace SqlBulkTools
{
    internal interface ITransactionWithMetadata : ITransaction
    {
        int CommitWithPrecomputedMetadata(SqlTransaction transaction, DataTable dtColumns);
    }
}