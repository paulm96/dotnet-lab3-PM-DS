using System.Data.Entity;

namespace WindowsFormsApp2
{
    public class TaskDB : DbContext
    {
        public TaskDB()
            : base("Lista_procesow")
        {
            Database.SetInitializer<TaskDB>(new TaskDbInitiializer());
        }
        public DbSet<Task> Tasks { get; set; }

        public void remove()
        {
            foreach (Task a in Tasks)
            {
                Tasks.Remove(a);
            }
        }

       



    }
}
