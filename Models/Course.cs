using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.MVC.Models
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public DateTime FirstDate { get; set; }

        public DateTime SecondDate { get; set; }

        public DateTime ThirdDate { get; set; }

        [ForeignKey("Id_user")]
        public Guid Id_user { get; set; }
        public User User { get; set; }
    }
}

