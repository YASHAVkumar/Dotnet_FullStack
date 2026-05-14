global using System;
global using System.Text;
global using System.Threading.Tasks;
global using System.Collections;
global using System.Collections.Generic;
global using System.Collections.Concurrent;
namespace TestingConsole.Bussiness
{
    public class Employee
    {
        public Employee()
        {
            System.Console.WriteLine("Main ctor");
        }
    }

    namespace Nested
    {
         public  class Employee
         {
            public Employee()
            {
                System.Console.WriteLine("Local nested ctor");
            }
         }
    }

}


