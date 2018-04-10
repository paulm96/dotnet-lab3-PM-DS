using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class TaskDbInitiializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TaskDB>
    {
        protected override void Seed(TaskDB context)
        {
             Task task = new Task() { Name = "proces1", Url= "ssdsdas", Mail="damiansz8@interia.pl ", Text="koty za płoty" };
           // task.Add();
            base.Seed(context);

        }
    }
}
