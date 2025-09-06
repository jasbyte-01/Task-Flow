using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public partial class TaskFlowDbContext : DbContext
{
    public TaskFlowDbContext(DbContextOptions<TaskFlowDbContext> options)
        : base(options) { }

    public virtual DbSet<User> Users { get; set; }
}
