using System;
namespace ClassesAndObjectsAssignment
{
    public class Math
    {
        public int Method1(int x)

        {
            int result = x + 5;
            return result;
        }
        public int Method2(decimal x)
       
        {
            int result = Convert.ToInt32(x) * 5;
            return result;

        }

        public int Method3(string x)
        {

            int result = Convert.ToInt32(x) / 2;
            return result;
        }

  
    }
}
