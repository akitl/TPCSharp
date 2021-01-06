using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1 : IParler
    {

        public Class1(string name)
        {
            this.name = name;
        }

        public Class1(Class1 c)
        {
            name = c.name;
            i = c.i;
        }

        public int i {get;set;}

        private string name;
        public string Name { set { name = value; } get { return name; } }

        public void Cris()
        {
            Console.WriteLine("yaah");
        }
    }
}
