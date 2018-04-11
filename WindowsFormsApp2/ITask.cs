using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class ITask
    {
        public int Id {get;set;}
        string name;
        IAction action;
        ICondition condition;
        public int? IActionId {get; set;}
    public int? IConditionId { get; set; }
        public virtual ICondition ICondition { get; set; }
        public virtual IAction IAction { get; set; }


        public ITask() { }
        public ITask(string _name, IAction _action, ICondition _condition)
        {
            name = _name;
            Action = _action;
            Condition = _condition;
        }

        public string Name { get => name; set => name = value; }
        //internal IAction Action { get => action; set => action = value; }
        //internal ICondition Condition { get => condition; set => condition = value; }
        public IAction Action { get => action; set => action = value; }
        public ICondition Condition { get => condition; set => condition = value; }
        public void Do()
        {
            if(Condition.Check())
                Action.Do();

        }

        public override string ToString()
        {
            return string.Format("{0}, {1} {2}",
                "Name task: " + this.Name, "Condition: " + this.Condition.ToString(), "Action: " + this.Action.ToString());
        }
    }
}
