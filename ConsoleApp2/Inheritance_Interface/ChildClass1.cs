using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Inheritance_Interface
{
    public class ChildClass1 : ParentClassA, Interface1
    {
        public   int sum()
        {
            return 0;
        }

        public int add(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
