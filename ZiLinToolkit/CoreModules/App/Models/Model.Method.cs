using ZiLinToolkit.CoreModules.SQLiteDB;

namespace ZiLinToolkit.CoreModules.App.Models
{
    public abstract partial class Model
    {
        public void Create() => Database.Insert(this);

        public void Update() => Database.Update(this);

        public static IEnumerable<T> Where<T>(Func<T, bool> predicate) where T : new() => Database.Where(predicate);

        public static T First<T>(Func<T, bool> predicate) where T : new() => Database.First(predicate);
    }
}
