using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata;
using Restaurant_Project.Models;
using Restaurant_Project.Repository;

namespace Restaurant_Project.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        public IFoodRepository Food { get; }

        public IChefRepository Chef { get; }

        public ICategoryRepository Category { get; }

        public ITableRepository Table { get; }

        public UserManager<ApplicationUser> UserManager { get; set ; }
        public SignInManager<ApplicationUser> SignInManager { get; set; }
    }
}
