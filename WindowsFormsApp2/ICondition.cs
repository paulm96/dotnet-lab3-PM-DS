using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public abstract class ICondition
    {
        public abstract bool Check();
        public abstract override string ToString();
    }
}