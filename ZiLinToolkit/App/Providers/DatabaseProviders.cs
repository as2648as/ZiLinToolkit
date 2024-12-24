using ZiLinToolkit.App.Models;

namespace ZiLinToolkit.App.Providers
{
    internal class DatabaseProviders
    {
        private readonly Type[] _Types = [
            typeof(AppWatchdog),
        ];

        public DatabaseProviders() => Initialize();

        public void Initialize() => Dependencies.Models.Databases.Connections.SQLite.SQLiteConnection
            .CreateTables(
                createFlags: SQLite.CreateFlags.None,
                types: _Types
            );
    }
}
