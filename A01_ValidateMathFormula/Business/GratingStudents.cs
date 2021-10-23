using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_ValidateMathFormula.Business
{
    public class GratingStudents
    {
        public List<int> aGratingStudents(List<int> grades)
        {
            List<int> redondeo = new List<int>(grades);
            List<int> result = new List<int>(grades);

            for(int i = 0; i< redondeo.Count; i++)
                redondeo[i] = redondeo[i] + (5 - (redondeo[i] % 5));

            for(int i=0; i<grades.Count; i++)
            {
                if(grades[i] >= 38)
                {
                    if((redondeo[i] - grades[i]) < 3)
                        result[i] = redondeo[i];
                }
            }

            return result;
        }
    }
}
