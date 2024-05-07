using Microsoft.EntityFrameworkCore;

namespace dev_quiz_api.Models
{
    public class DevQuizDbContext : DbContext
    {
        public DevQuizDbContext(DbContextOptions<DevQuizDbContext> options) : base(options) { }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Participant> Participants { get; set; }
    }
}
