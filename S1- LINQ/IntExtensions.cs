using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1__LINQ
{
    public static class IntExtensions
    {
        public static int Reverse(this int Number)
        {
            int ReversedNum = 0, reminder;
            while(Number != 0 )
            {
                reminder = Number % 10;
                ReversedNum = ReversedNum *10 + reminder;
                Number = Number / 10;
            }
            return ReversedNum;

        }
    }
}
