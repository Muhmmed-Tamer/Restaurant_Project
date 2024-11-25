using Restaurant_Project.Repository;
using Restaurant_Project.Services;

namespace Restaurant_Project.Extension_Methods
{
    public static class ExtenstionMethod
    {
        public static void DependencyInjectionOfClassesAndInterfaces(this IServiceCollection Services)
        {
            Services.AddScoped<IChefRepository, ChefRepository>();           
            Services.AddScoped<ITableRepository, TableRepository>();           
            Services.AddScoped<ICategoryRepository, CategoryRepository>();           
            Services.AddScoped<IFoodRepository, FoodRepository>();           
            Services.AddScoped<IUnitOfWork, UnitOfWork>();           
            
        }
    }
}
