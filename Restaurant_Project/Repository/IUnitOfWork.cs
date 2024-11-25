using Microsoft.AspNetCore.Identity;
using Restaurant_Project.Models;

namespace Restaurant_Project.Repository
{
    public interface IUnitOfWork
    {
        public IFoodRepository Food { get; }
        public IChefRepository Chef { get; }
        public ICategoryRepository Category { get; }
        public ITableRepository Table { get; }
        public UserManager<ApplicationUser> UserManager { get; set; }
        public SignInManager<ApplicationUser> SignInManager { get; set; }

    }
}
