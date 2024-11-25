using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Restaurant_Project.Models
{
    public class ApplicationUser : IdentityUser
    {
        [ValidateNever]
        public ICollection<Table>? Tables { get; set; }
        [ValidateNever]
        public ICollection<Food>? Foods { get; set; }
    }
}
