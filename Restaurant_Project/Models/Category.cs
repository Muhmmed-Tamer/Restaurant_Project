using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Restaurant_Project.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        [ValidateNever]
        public ICollection<Food> ?  Foods { get; set; }
    }
}
