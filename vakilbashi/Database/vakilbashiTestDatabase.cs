using SQLite;

namespace vakilbashi.Database
{
    public class vakilbashiTestDatabase
    {
        SQLiteAsyncConnection Database;
        public vakilbashiTestDatabase()
        {
            
        }

        private async Task Init()
        {
            if (Database is not null)
            {
                return;
            }
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            //var result = await Database.CreateTableAsync<کلاس مدل > ();
        }
    }
}
