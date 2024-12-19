using ZiLinToolkit.App.Models;

namespace ZiLinToolkit.CoreModules.SQLiteDB
{
    public partial class Database
    {
        private static void Migrate()
        {
            Conn.CreateTable<Test>(SQLite.CreateFlags.ImplicitPK);
        }
    }
}
