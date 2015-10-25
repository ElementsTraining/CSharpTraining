using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondProject
{
    public class TestClass
    {
        public TestClass()
        {
            Console.Write("D");
        }
    }

    public class SecondClass : TestClass
    {
        public SecondClass()
        {
            Console.Write("C");
            writeClaudio();
        }
        
        public void writeClaudio()
        {
            Console.Write("J");
        }
    }
}
