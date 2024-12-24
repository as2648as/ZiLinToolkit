using ZiLinToolkit.Dependencies.Models.Databases.Interfaces;
using ZiLinToolkit.Dependencies.Models.Interfaces;

namespace ZiLinToolkit.Dependencies.Models
{
    public abstract partial class Model : IModelable
    {
        private static IDatabaseable DB { get; set; } = new Databases.Connections.SQLite();

        public Model() { }

        public Model(IDatabaseable database) => DB = database;

        /// <summary>
        /// 將此 Model 實例新建至資料庫中。
        /// </summary>
        public virtual void Create() => DB.Create(this);

        /// <summary>
        /// 將此 Model 實例從資料庫中刪除。
        /// </summary>
        public virtual void Delete() => DB.Delete(this);

        /// <summary>
        /// 將此 Model 實例從資料庫中更新。
        /// </summary>
        public virtual void Update() => DB.Update(this);

        /// <summary>
        /// 我是誰，我在哪裡？
        /// </summary>
        public virtual void Where() => DB.Where();

        /// <summary>
        /// 你又是誰？
        /// </summary>
        public virtual void First() => DB.Find();
    }
}
