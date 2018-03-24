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

        public int AddNumbers(string number)
        {
            var total = number;

            if (total == "")
            {
                return 0;
            }
            else
            {
                
                var actualnumber = int.Parse(number);
               
                for (var i = 0; i < actualnumber.length(); i++)
                {

                }
                return actualnumber;
            }
        }
//        int number = Convert.ToInt32(originalString);
//        number += 1;
//string newString = number.ToString();

    }
}
