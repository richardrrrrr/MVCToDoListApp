using System.ComponentModel.DataAnnotations;

namespace MVCToDoListApp.Models
{
	public class Habit
	{
		[Key]
		public int HabitID { get; set; }
		public string UserID { get; set; }
		public string HabitName { get; set; }
		public DateTime StartDate { get; set; }
		public int Frequency { get; set; }

		public User User { get; set; }
		public ICollection<HabitLog> HabitLogs { get; set; }
	}
}
