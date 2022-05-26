using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csVariablesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "Lucie";
            int age = 8;
            char lastInital = 'O';
            bool isYoung = true;
            double heightFt = 4.5;
            decimal weight = 100.3m;

            Console.WriteLine($"I love {name} {lastInital}.  She is {age} years old.  It is {isYoung} that she is young.  She is {heightFt} feet tall and weighs {weight} lbs");
        }
    }
}
