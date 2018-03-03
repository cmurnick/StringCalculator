using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class NumberAdder
    {
        public NumberAdder()
        {

        }

        public string AddNumbers(string number)
        {
            var total = number;
            //var total = int.Parse(number);
            if (total == "")
            {
                number = "0";
                return number;
            }
            return "Stupid";
        }
//        int number = Convert.ToInt32(originalString);
//        number += 1;
//string newString = number.ToString();

    }
}
