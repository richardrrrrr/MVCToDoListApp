using Microsoft.AspNetCore.Identity;

namespace MVCToDoListApp.Models
{
	public class User: IdentityUser
	{
		public DateTime LastLoginTime { get; set; }
		public ICollection<Goal> Goals { get; set; }
		public ICollection<TeamMember> TeamMembers { get; set; }
		public ICollection<Habit> Habits { get; set; }
	}

	
}
