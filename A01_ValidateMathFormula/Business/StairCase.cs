using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_ValidateMathFormula.Business
{
    public class StairCase
    {
        public void aStairCase(int n)
        {
            char pad = '#';
            int[] arr_espacios = new int[n];
            int[] arr_invertido = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr_espacios[i] = n - i;
            }

            arr_invertido = arr_espacios.AsEnumerable().Reverse().ToArray();

            for(int i=0; i<n; i++)
            {
                for(int j=0; j<arr_espacios[i]-1; j++)
                    Console.Write(" ");

                for(int k=0; k<arr_invertido[i]; k++)
                    Console.Write(pad);

                Console.Write(Environment.NewLine);
            }

        }
    }
}


/*
   #
  ##
 ###
####
 */