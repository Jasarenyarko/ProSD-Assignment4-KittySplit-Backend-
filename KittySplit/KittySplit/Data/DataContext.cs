using Microsoft.EntityFrameworkCore;
using KittySplit.Models;
using KittySplit.Services;

namespace KittySplit.Data
{
    public class DataContext : DbContext{
    public class DataContext(DbContextOptions<DataContext> options) : base(options) { }
    
    public DbSet<Kitty> Kitties { get; set; }
    public DbSet<Participant> Participants { get; set; }
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
       
    }
}}
