using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        string binary = Convert.ToString(n, 2);


        if (binary.Contains('1'))
        {

            List<int> listOfOneIndexes = new List<int>();
            List<int> listOfCounts = new List<int>();

            int count = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                    count++;

                var x = binary.Length - 1;

                if (count != 0 && binary[i] != '1' || i == binary.Length - 1)
                {
                    listOfOneIndexes.Add(count);
                    count = 0;
                }
            }

            int maxAge = listOfOneIndexes.Max();

            if (listOfOneIndexes.Any())
            {
                Console.WriteLine(listOfOneIndexes.Max());
            }
            else
                Console.WriteLine(0);
        }
    }
}
