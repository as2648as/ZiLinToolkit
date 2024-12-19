using SQLite;

namespace ZiLinToolkit.CoreModules.SQLiteDB
{
    public static partial class Database
    {
        private static SQLiteConnection Conn { get; set; } = new("sqlite.db");
    }
}
