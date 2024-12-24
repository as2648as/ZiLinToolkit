namespace ZiLinToolkit.Dependencies.Models.Interfaces
{
    internal interface IModelable
    {
        public void Create();

        public void Update();

        public void Delete();

        public void Where();

        public void First();
    }
}
