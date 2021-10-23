using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_ValidateMathFormula.Business
{
    public class DiagonalDifference
    {
        public int diagonalDifferente(List<List<int>> arr)
        {
            int[][] mat = arr.Select(m => m.ToArray()).ToArray();
            int left = 0, right = 0;

            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat.Length; j++)
                {
                    if (i.Equals(j))                
                        left += mat[i][j];

                    if ((i + j) == (mat.Length - 1))
                        right += mat[i][j];
                }
            }

            return Math.Abs(left - right);
        }
    }
}
