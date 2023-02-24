using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.MVC.Models
{
    [Table("User")]
    public class User
	{
		[Key]
		public Guid Id { get; set; }

		public string? Name { get; set; }
					
		public string? Surname { get; set; }
					 
		public string? Nickname { get; set; }
					 
		public string? Email { get; set; }
					 
		public string? Password { get; set; }

		public bool Role { get; set; }
	}
}

