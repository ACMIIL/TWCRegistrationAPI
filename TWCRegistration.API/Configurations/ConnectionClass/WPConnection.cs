using System.Data;

namespace TWCRegistration.API.ConnectionClass
{
    public class WPConnection : IDBConnection
    {
        public WPConnection(IDbConnection dBConnection)
        {
            Connection = dBConnection;
        }

        public string ConnectionName
        {
            get { return "WPConnection"; }
        }

        public IDbConnection Connection { get; set; }
    }
}
