using System.Data;

namespace SubtleArtOfUnitTesting.EasyToWrite
{
    public class Database
    {
        public Database(string connectionString)
        {
            
        }

        public DataTable Get(string query)
        {
            return new DataTable();
        }

        public void Execute(string query)
        {

        }
    }
}