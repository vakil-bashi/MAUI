﻿namespace vakilbashi.Database
{
    public static class Constants
    {
        public const string DatabaseFilename = "vakilbashiTestSQLite.db3";
        public const SQLite.SQLiteOpenFlags Flags =
            SQLite.SQLiteOpenFlags.ReadWrite
            | SQLite.SQLiteOpenFlags.Create
            | SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath = Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);
    }
}