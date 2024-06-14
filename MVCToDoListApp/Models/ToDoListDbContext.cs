using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MVCToDoListApp.Models
{
	public class ApplicationDbContext : IdentityDbContext<User>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Goal> Goals { get; set; }
		public DbSet<ToDoItem> ToDoItems { get; set; }
		public DbSet<Team> Teams { get; set; }
		public DbSet<TeamMember> TeamMembers { get; set; }
		public DbSet<Habit> Habits { get; set; }
		public DbSet<HabitLog> HabitLogs { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			// User 和 Goal 之間的一對多關係
			modelBuilder.Entity<Goal>()
				.HasOne(g => g.User)
				.WithMany(u => u.Goals)
				.HasForeignKey(g => g.UserID);

			// Goal 和 ToDoItem 之間的一對多關係
			modelBuilder.Entity<ToDoItem>()
				.HasOne(t => t.Goal)
				.WithMany(g => g.ToDoItems)
				.HasForeignKey(t => t.GoalID);

			// Team 和 TeamMember 之間的一對多關係
			modelBuilder.Entity<TeamMember>()
				.HasOne(tm => tm.Team)
				.WithMany(t => t.TeamMembers)
				.HasForeignKey(tm => tm.TeamID);

			// User 和 TeamMember 之間的一對多關係
			modelBuilder.Entity<TeamMember>()
				.HasOne(tm => tm.User)
				.WithMany(u => u.TeamMembers)
				.HasForeignKey(tm => tm.UserID);

			// User 和 Habit 之間的一對多關係
			modelBuilder.Entity<Habit>()
				.HasOne(h => h.User)
				.WithMany(u => u.Habits)
				.HasForeignKey(h => h.UserID);

			// Habit 和 HabitLog 之間的一對多關係
			modelBuilder.Entity<HabitLog>()
				.HasOne(hl => hl.Habit)
				.WithMany(h => h.HabitLogs)
				.HasForeignKey(hl => hl.HabitID);
		}

	}
}
