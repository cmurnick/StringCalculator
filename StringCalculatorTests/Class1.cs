using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringCalculator;

namespace StringCalculatorTests
{
    public class Class1
    {
        [TestFixture]
        public class AddNumbersTests
        {
            [Test]
            public void Entering_an_empty_string_results_in_the_sum_of_zero()
            {
                //Arrange -
                var number = "";
                var numberAdder = new NumberAdder();
                //Act-
                var result = numberAdder.AddNumbers(number);
                //Assert-
                Assert.AreEqual("0", result);
            }
        }
    }


}
