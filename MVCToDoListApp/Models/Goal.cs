using System.ComponentModel.DataAnnotations;

namespace MVCToDoListApp.Models
{
	public class Goal
	{
		[Key]
		public int GoalID { get; set; }
		public string UserID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public int Progress { get; set; }

		public User User { get; set; }
		public ICollection<ToDoItem> ToDoItems { get; set; }
	}
}
