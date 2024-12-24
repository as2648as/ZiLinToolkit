using SQLite;
using ZiLinToolkit.Dependencies.Models;

namespace ZiLinToolkit.App.Models
{
    public class AppWatchdog : Model
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; } = null!;

        [NotNull]
        [Column("executePath")]
        public string ExecutePath { get; set; } = null!;

        [Column("description")]
        public string Description { get; set; } = null!;

        [NotNull]
        [Column("interval")]
        public int? Interval { get; set; } = null!;
    }
}
