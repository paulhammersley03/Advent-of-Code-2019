using System;
using System.Collections.Generic;
using System.Text;

namespace Advent_of_Code
{
    public class Calculation
    {
        public int GetAnswer(List<int> dataList)
        {
            int answer = 0;

            foreach (var number in dataList)
            {
                answer = answer + number / 3 - 2;
            }
            return answer;
        }
    }
}
