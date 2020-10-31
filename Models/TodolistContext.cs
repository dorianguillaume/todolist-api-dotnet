 using Microsoft.EntityFrameworkCore;
public class TodolistContext : DbContext
{
    public TodolistContext(DbContextOptions<TodolistContext> options) : base(options)
    {

    }
    public DbSet<Task> Task { get; set; }
}