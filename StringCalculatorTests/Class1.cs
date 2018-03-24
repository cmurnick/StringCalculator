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
                Assert.AreEqual(0, result);
            }
        }

        [Test]
        public void
            Entering_one_number_returnss_the_same_numer()
        { 
            //Arrange -
            var number = "1";
            var numberAdder = new NumberAdder();
            //Act-
            var result = numberAdder.AddNumbers(number);
            //Assert-
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Entering_multiple_numbers_and_have_them_all_add()
        {
            //Arrange -
            var number = "2,3,4";
            var numberAdder = new NumberAdder();
            //Act-
            var result = numberAdder.AddNumbers(number);
            //Assert-
            Assert.AreEqual(9, result);
        }
    }


}
