using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_ValidateMathFormula.Business
{
    public class TimeConversion
    {
        public string aTimeConversion(string s)
        {
            return Convert.ToDateTime(s).ToString("HH:mm:ss");
        }
    }
}
