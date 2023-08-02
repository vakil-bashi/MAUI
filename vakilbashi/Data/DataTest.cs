
namespace vakilbashi.Data
{
    public class DataTest
    {
        public static string GetLocalPath(string filename)
        {
            return System.IO.Path.Combine(FileSystem.AppDataDirectory, filename);
        }
    }
}
