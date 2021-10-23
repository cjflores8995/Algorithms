using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_ValidateMathFormula.Business
{
    public class CompararTriples
    {
        public List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>() { 0, 0 };

            for(int i=0; i< a.Count; i++)
            {
                if(a[i] > b[i])
                    result[0]++;
                else if(b[i] > a[i])
                    result[1]++;
            }
            return result;
        }
    }
}
