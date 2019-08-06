using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TodoAppData.Models.ModelConfigurations;

namespace TodoAppData.Models
{
	public class TodoAppContext : DbContext
	{
		public TodoAppContext(DbContextOptions<TodoAppContext> options)
			:base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
			=> modelBuilder.ApplyConfiguration(new TodoConfiguration());

		public DbSet<Todo> Todo { get; set; }
	}
}
