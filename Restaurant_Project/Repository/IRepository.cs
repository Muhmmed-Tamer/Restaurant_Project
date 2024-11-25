namespace Restaurant_Project.Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Save();
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
