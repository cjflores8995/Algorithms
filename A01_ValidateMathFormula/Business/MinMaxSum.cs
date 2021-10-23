using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_ValidateMathFormula.Business
{
    public class MinMaxSum
    {
        public void aMinMaxSum(List<Int64> arr)
        {
            List<Int64> result = new List<Int64>(){ 0, 0 };

            arr = arr.OrderBy(x => x).ToArray().ToList();

            for(int i=0; i<arr.Count; i++)
            {
                if (i == 0)
                {
                    result[0]+= arr[i];
                } 
                else if (i== arr.Count-1)
                {
                    result[1] += arr[i];
                }
                else
                {
                    result[0] += arr[i];
                    result[1] += arr[i];
                }
            }

            Console.WriteLine($"{result[0]} {result[1]}");
        }
    }
}
