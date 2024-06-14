using System.ComponentModel.DataAnnotations;

namespace MVCToDoListApp.Models
{
	public class Team
	{
		[Key]
		public int TeamID { get; set; }
		public string TeamName { get; set; }

		public ICollection<TeamMember> TeamMembers { get; set; }
	}
}
