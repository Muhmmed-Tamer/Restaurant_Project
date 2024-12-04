using Restaurant_Project.Data;
using Restaurant_Project.Models;
using Restaurant_Project.Repository;

namespace Restaurant_Project.Services
{
    public class TableRepository : ITableRepository
    {
        ContextData Context;
        public TableRepository(ContextData Context)
        {
            this.Context = Context;
        }
        public void Add(Table entity)
        {
            Context.Add(entity);
        }

        public void Delete(int id)
        {
            Context.Remove(GetById(id));
        }

        public List<Table> GetAll()
        {
            return Context.Tables.ToList();
        }

        public Table GetById(int id)
        {
            return Context.Tables.FirstOrDefault(C => C.Id == id);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Update(Table entity)
        {
            Context.Tables.Update(entity);
        }
    }
}
