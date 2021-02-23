using System;

namespace ClassTwoParameters
{
    public class Param
    {
       public int Method1(int x, int y = 0)
        {
            int result = x + y;
            return result;
        }
    }
}
