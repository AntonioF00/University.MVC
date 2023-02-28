using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.MVC.Models
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        public string Description { get; set; }
        public List<User>? Users { get; set; } 
    }
}

