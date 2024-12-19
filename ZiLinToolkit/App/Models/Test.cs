using SQLite;
using ZiLinToolkit.CoreModules.App.Models;
using ZiLinToolkit.CoreModules.App.Models.Interfaces;

namespace ZiLinToolkit.App.Models
{
    [Table("Test")]
    public partial class Test : Model, INameable
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [NotNull]
        [Column("name")]
        public string Name { get; set; } = null!;
    }
}
