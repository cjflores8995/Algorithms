using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_ValidateMathFormula.Business
{
    public class BirthdayCakeCandles
    {
        public int birthdayCakeCandles(List<int> candles)
        {
            int max = candles.Max();
            int result = 0;

            foreach(int num in candles)
            {
                if (num.Equals(max))
                    result++;
            }
            return result;
        }
    }
}
