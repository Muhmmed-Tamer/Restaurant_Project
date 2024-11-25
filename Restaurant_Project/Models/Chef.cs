using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant_Project.Models
{
    public class Chef
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURL {  get; set; }
        [NotMapped]
        public IFormFile Img {  get; set; }
        public decimal ?  Salary {  get; set; }
        public string Specialty {  get; set; }
        public Food? Food { get; set; }
        [ForeignKey("Food")]
        public int FoodId { get; set; }

    }
}
