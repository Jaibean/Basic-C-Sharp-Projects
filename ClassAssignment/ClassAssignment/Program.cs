using System;
using System.Collections.Generic;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        { 

            Math myMethod = new Math();
            myMethod.MathOpp(3, 5);
            myMethod.MathOpp(x: 8, y: 10);

        }
    }
}
