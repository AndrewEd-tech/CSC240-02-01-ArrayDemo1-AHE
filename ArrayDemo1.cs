using System;
using static System.Console;

namespace CSC240_02_01_ArrayDemo_AHE
{
    class ArrayDemo1
    {

        static void Main(string[] args)
        {
            // STORAGE
            double[] payRate = { 13.0, 17.35, 19.12, 22.45 };
            double[] grades = { 95, 58, 45, 1, 90 };
            // INPUT

            //PROCESS
            for (int x = 0; x < payRate.Length; ++x)
            {
                WriteLine("Pay Rate {0} is {1}", x + 1, payRate[x].ToString("C"));
            }
            //OUTPUT


        }
    }
}