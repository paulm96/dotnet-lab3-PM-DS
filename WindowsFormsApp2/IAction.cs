using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public abstract class IAction
    {
        public abstract void Do();
        public abstract override string ToString();
    }
}
