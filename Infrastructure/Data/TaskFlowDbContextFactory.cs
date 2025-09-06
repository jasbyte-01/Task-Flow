using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Data
{
    public class TaskFlowDbContextFactory : IDesignTimeDbContextFactory<TaskFlowDbContext>
    {
        public TaskFlowDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<TaskFlowDbContext> optionsBuilder = new();
            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=TaskFlow;Trusted_Connection=True;TrustServerCertificate=True;"
            );

            return new TaskFlowDbContext(optionsBuilder.Options);
        }
    }
}
