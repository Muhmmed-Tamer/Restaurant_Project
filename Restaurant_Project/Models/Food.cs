using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant_Project.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL {  get; set; }
        [NotMapped]
        public IFormFile Img {  get; set; }
        public Category ?Category { get; set; }
        [ForeignKey("Category")]
        public int CategoryId {  get; set; }
        [ValidateNever]
        public ICollection<Chef>? Chef { get; set; }

    }
}
