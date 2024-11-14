using System.Data;

namespace DatabankApi.Database;

public interface IDbConnectionFactory{
    public Task<IDbConnection> CreateConnectionAsync();
}