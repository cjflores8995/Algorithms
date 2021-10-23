using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_ValidateMathFormula.Business
{
    public class AverageArray
    {
        public void plusMinus(List<int> arr)
        {
            int[] total = new int[] { 0, 0 ,0 };
            double[] result = new double[] { 0, 0 ,0 };

            foreach (int num in arr)
            {
                if (num > 0)
                    total[0]++;
                else if(num < 0)
                    total[1]++;
                else
                    total[2]++;
            }

            for(int i=0; i< total.Length; i++)
                result[i] = Math.Round(((Convert.ToDouble(total[i]) * 100) / Convert.ToDouble(arr.Count)), 4);

            foreach(var res in result)
                Console.WriteLine((res / 100).ToString().Length == 3 ? (res / 100).ToString().Replace(",", ".") + "00000" : (res / 100).ToString().Replace(",", "."));
        }
    }
}
