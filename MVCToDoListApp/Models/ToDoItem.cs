using System.ComponentModel.DataAnnotations;

namespace MVCToDoListApp.Models
{
	public class ToDoItem
	{
		[Key]
		public int ToDoItemID { get; set; }
		public int? GoalID { get; set; }
		public string Description { get; set; }
		public DateTime DueDate { get; set; }
		public string Status { get; set; }

		public Goal Goal { get; set; }
	}
}
