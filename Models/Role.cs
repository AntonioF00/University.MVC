using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.MVC.Models
{
    [Table("Role")]
    public class Role
	{
		[Key]
		public Guid Id { get; set; }
		
		public string? Description { get; set; }
        
		[ForeignKey("Id_user")]
        public Guid Id_user { get; set; }

	}
}

