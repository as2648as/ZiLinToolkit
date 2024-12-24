using SQLite;
using ZiLinToolkit.Dependencies.Models.Databases.Interfaces;

namespace ZiLinToolkit.Dependencies.Models.Databases.Connections
{
    public class SQLite : IDatabaseable
    {
        public static SQLiteConnection SQLiteConnection { get; } = new("sqlite.db");

        public SQLite() { }

        public void Create(Model model)
            => SQLiteConnection.Insert(model);

        public void Delete(Model model)
            => SQLiteConnection.Delete(model);


        public void Update(Model model)
            => SQLiteConnection.Update(model);

        public void Find()
            => throw new NotImplementedException();

        public void Where()
            => throw new NotImplementedException();
    }
}
