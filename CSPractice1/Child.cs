using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice1
{
    internal class Child : Parent
    {
        public Child() : base("input")
        {
            Console.WriteLine("자식 생성자 호출");
        }

        public Child(string input) : base(input)
        {
            Console.WriteLine("Child(string input):base(input)");
        }
    }
}