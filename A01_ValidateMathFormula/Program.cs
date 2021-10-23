using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using objValidateFormula = A01_ValidateMathFormula.Business;

namespace A01_ValidateMathFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>() { 84, 29, 57 };

            var result = new Business.GratingStudents().aGratingStudents(grades);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //string s = "12:01:00AM";

            //Console.WriteLine(new Business.TimeConversion().aTimeConversion(s));

            //List<int> candles = new List<int>() { 3,2,1,3};

            //Console.WriteLine(new Business.BirthdayCakeCandles().birthdayCakeCandles(candles));

            //List<Int64> arr = new List<Int64>() { 793810624, 895642170, 685903712, 623789054, 468592370 };

            //new Business.MinMaxSum().aMinMaxSum(arr);

            //new Business.StairCase().aStairCase(6);

            //List<int> arr = new List<int>() { 1,1,0,-1,-1 };

            //new Business.AverageArray().plusMinus(arr);

            //List<List<int>> arr = new List<List<int>>() { 
            //    new List<int>{ 1,2,3,4 },
            //    new List<int>{ 5,6,7,8 },
            //    new List<int>{ 9,10,11,12},
            //    new List<int>{ 20,14,15,16},
            //};

            //Console.WriteLine(new Business.DiagonalDifference().diagonalDifferente(arr));

            //foreach (var num in arr)
            //{
            //    for(int i=0; i< num.Count; i++)
            //    {
            //        Console.Write($"{num[i]}[{i},{j}]\t");
            //    }
            //    Console.WriteLine(Environment.NewLine);
            //}

            //List<long> ar = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

            //Console.WriteLine(new Business.VerifyBigSum().aVerifyBigSum(ar));

            //List<int> a = new List<int>() { 17, 28, 30 };
            //List<int> b = new List<int>() { 99, 16, 8 };

            //var result = new Business.CompararTriples().compareTriplets(a, b);

            //foreach(var num in result)
            //{
            //    Console.Write($"{num}, ");
            //}

            Console.ReadKey();
        }

    }
}
