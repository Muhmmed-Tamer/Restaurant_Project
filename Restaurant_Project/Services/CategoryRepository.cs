using Restaurant_Project.Data;
using Restaurant_Project.Models;
using Restaurant_Project.Repository;

namespace Restaurant_Project.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        ContextData Context;
        public CategoryRepository(ContextData Context)
        {
            this.Context = Context;
        }
        public void Add(Category entity)
        {
            Context.Add(entity);
        }

        public void Delete(int id)
        {
            Context.Remove(GetById(id));
        }

        public List<Category> GetAll()
        {
            return Context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return Context.Categories.FirstOrDefault(C=>C.Id == id);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Update(Category entity)
        {
            Context.Categories.Update(entity);
        }
    }
}
