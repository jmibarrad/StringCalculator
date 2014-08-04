using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace LogicGoesHere
{
    public class LogicGoesHereClass
    {

        //Problema #1
        public int Calculate1(string value)
        {
            if (value==string.Empty)
            {
                return 0;

            }


            return -1;
        }

        //Re-master ALL
        private const int MaxNumber = 1000;

        public int Add(string numberStr)
        {
            List<int> values = GetNumbers(numberStr);
            List<int> negativeNumbers = values.Where(num => num < 0).ToList();

            //If any negative numbers are in the list must return exception 
            if (negativeNumbers.Any())
                throw new Exception("Negatives not allowed, negative numbers: " + string.Join(", ", negativeNumbers).ToString());
            else
                return values.Where(num => num < MaxNumber).Sum();
        }

        private static List<int> GetNumbers(string values)
        {
            char[] delimiters = values.Where(c => !Char.IsNumber(c) && c != '-').Distinct().ToArray();
            return values.Split(delimiters).Where(num => !String.IsNullOrEmpty(num.ToString())).Select(int.Parse).ToList<int>();
        }

        




    }
}
