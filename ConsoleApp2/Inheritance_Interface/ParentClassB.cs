using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Inheritance_Interface
{
    public class ParentClassB : Interface2
    {
      


       public string Name()
        {
            return "Name function";
        }

         
        int Interface1.add(int x, int y)
        {
            throw new NotImplementedException();
        }

        int Interface1.sum()
        {
            throw new NotImplementedException();
        }

      


    }
}
