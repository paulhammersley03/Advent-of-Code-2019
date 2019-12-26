using System;
using System.Collections.Generic;

namespace Advent_of_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dataList = new GetData().GetNumberInput();//call getdata class to turn txt file into integer list
            var answer = new Calculation().GetAnswer(dataList);//call calculation class to run calculation on returned integer list
            Console.WriteLine("The amount of fuel needed is: " + answer);//prints out the answer
            //dataList.ForEach(i => Console.Write("{0}\t", i));//prints out each item in the integer list using lambda method
            Console.ReadLine();
        }
    }
}
