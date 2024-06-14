using System.ComponentModel.DataAnnotations;

namespace MVCToDoListApp.Models
{
	public class HabitLog
	{
		[Key]
		public int LogID { get; set; }
		public int HabitID { get; set; }
		public DateTime Date { get; set; }
		public string Status { get; set; }

		public Habit Habit { get; set; }
	}
}
