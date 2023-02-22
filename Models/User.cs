using System;
using System.ComponentModel.DataAnnotations;

namespace University.MVC.Models
{
	public class User
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public string Nickname { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public bool Role { get; set; }
	}
}

