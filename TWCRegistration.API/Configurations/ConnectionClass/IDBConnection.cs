using System.Data;

namespace TWCRegistration.API.ConnectionClass
{
    public interface IDBConnection
    {
        public string ConnectionName { get; }
        public IDbConnection Connection { get; }
    }
}
