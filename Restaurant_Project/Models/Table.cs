using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant_Project.Models
{
    public class Table
    {
        public int Id { get; set; }
        [DisplayName("Table Number")]
        public int TableNumber { get; set; }
        [Range(1, 4)]
        public int Capacity { get; set; }
        public string Status { get; set; }
        public ApplicationUser User { get; set; }
        [ForeignKey("User")]
        public string ApplicationUserId { get; set; }

        public DateTime BookedTableAt {get;set;} = DateTime.Now;
        public DateTime ExpiredOfBookATable { get;set;} = DateTime.Now.AddMinutes(30);

    }
}
