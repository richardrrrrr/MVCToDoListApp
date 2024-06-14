using System.ComponentModel.DataAnnotations;

namespace MVCToDoListApp.Models
{
	public class TeamMember
	{
		[Key]
		public int TeamID { get; set; }
		public string UserID { get; set; }
		public string Role { get; set; }

		public Team Team { get; set; }
		public User User { get; set; }
	}
}
