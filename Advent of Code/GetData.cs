using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;


namespace Advent_of_Code
{
    public class GetData
    {
        public List<int> GetNumberInput()
        {
            List<int> numberList = File.ReadLines($"C:/Users/minim/Documents/C# Projects/Advent of Code/Day 1 Data.txt").Select(int.Parse).ToList();//reads data from txt file and turns it into an integer list
            return numberList;
        }
    }
}