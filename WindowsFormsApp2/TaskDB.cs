using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public DbSet<Task> Task { get; set; }



    }
}
