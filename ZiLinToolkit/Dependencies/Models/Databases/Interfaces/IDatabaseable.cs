namespace ZiLinToolkit.Dependencies.Models.Databases.Interfaces
{
    public interface IDatabaseable
    {
        void Create(Model model);

        void Update(Model model);

        void Delete(Model model);

        void Where();

        void Find();
    }
}
