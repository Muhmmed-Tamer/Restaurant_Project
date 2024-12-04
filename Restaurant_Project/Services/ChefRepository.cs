using Restaurant_Project.Data;
using Restaurant_Project.Models;
using Restaurant_Project.Repository;

namespace Restaurant_Project.Services
{
    public class ChefRepository : IChefRepository
    {
        ContextData Context;
        public ChefRepository(ContextData Context)
        {
            this.Context = Context;
        }
        public void Add(Chef entity)
        {
            Context.Add(entity);
        }

        public void Delete(int id)
        {
            Context.Remove(GetById(id));
        }

        public List<Chef> GetAll()
        {
            return Context.Chefs.ToList();
        }

        public Chef GetById(int id)
        {
            return Context.Chefs.FirstOrDefault(C => C.Id == id);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Update(Chef entity)
        {
            Context.Chefs.Update(entity);
        }
    }
}
