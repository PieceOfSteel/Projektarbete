namespace Projekt_C.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        void Add(IPersistent persistent);
        void Remove(IPersistent persistent);
    }
}
