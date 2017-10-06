using System;

namespace MyService
{
    public class MyService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }

            throw new NotImplementedException("Please create a test first");
        }
       
        public int Add(int x, int y)
        {
            return x + y;
        }

        public bool IsOdd(int candidate)
        {
            return candidate % 2 == 1;
        }
    }
}
