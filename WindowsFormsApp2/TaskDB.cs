using System.Data.Entity;

namespace WindowsFormsApp2
{
    public class TaskDB : DbContext
    {
        public TaskDB()
            : base("Lista_procesow")
        {
            Database.SetInitializer(new TaskDbInitiializer());
        }
        public DbSet<Task> Tasks { get; set; }



    }
}
