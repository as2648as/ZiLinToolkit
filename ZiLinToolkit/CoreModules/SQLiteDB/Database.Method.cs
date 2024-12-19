using ZiLinToolkit.CoreModules.App.Models;

namespace ZiLinToolkit.CoreModules.SQLiteDB
{
    public static partial class Database
    {
        public static void Initialize() => Migrate();

        public static void Insert(Model model) => Conn.Insert(model);

        public static void Update(Model model) => Conn.Update(model);

        public static void Delete(Model model) => Conn.Delete(model);

        public static IEnumerable<T> Where<T>(Func<T, bool> predicate) where T : new() => Conn.Table<T>().Where(predicate);

        public static T First<T>(Func<T, bool> predicate) where T : new() => Conn.Table<T>().First(predicate);
    }
}
