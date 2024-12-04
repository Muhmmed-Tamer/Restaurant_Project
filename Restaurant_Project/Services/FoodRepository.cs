using Restaurant_Project.Data;
using Restaurant_Project.Models;
using Restaurant_Project.Repository;

namespace Restaurant_Project.Services
{
    public class FoodRepository : IFoodRepository
    {
        ContextData Context;
        public FoodRepository(ContextData Context)
        {
            this.Context = Context;
        }
        public void Add(Food entity)
        {
            Context.Add(entity);
        }

        public void Delete(int id)
        {
            Context.Remove(GetById(id));
        }

        public List<Food> GetAll()
        {
            return Context.Foods.ToList();
        }

        public Food GetById(int id)
        {
            return Context.Foods.FirstOrDefault(C => C.Id == id);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Update(Food entity)
        {
            Context.Foods.Update(entity);
        }
    }
}
