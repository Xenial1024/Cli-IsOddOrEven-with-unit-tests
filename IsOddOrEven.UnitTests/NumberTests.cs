using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsOddOrEven.UnitTests
{
    class NumberTests
    {
        [Test]
        public void IsEvenOrOdd_WhenInputIsEven_ShouldWriteThatItIsEven()
        {
            // Arrange
            StringReader input = new StringReader("2");
            Console.SetIn(input);

            // Act
            string result = IsOddOrEven.Number.IsEvenOrOdd();

            // Assert
            Assert.That(result, Is.EqualTo("jest parzysta"));
        }

        [Test]
        public void IsEvenOrOdd_WhenInputIsOdd_ShouldWriteThatItIsOdd()
        {
            // Arrange
            StringReader input = new StringReader("3");
            Console.SetIn(input);

            // Act
            string result = IsOddOrEven.Number.IsEvenOrOdd();

            // Assert
            Assert.That(result, Is.EqualTo("jest nieparzysta")); 
        }

        [Test]
        public void IsEvenOrOdd_WhenInputIsFloat_ShouldReturnNotEvenNotOdd()
        {
            // Arrange
            StringReader input = new StringReader("2,5");
            Console.SetIn(input);

            // Act
            string result = IsOddOrEven.Number.IsEvenOrOdd();

            // Assert
            Assert.That(result, Is.EqualTo("nie jest ani parzysta ani nieparzysta"));
        }

        [Test]
        [Timeout(3000)] 
        public void IsEvenOrOdd_WhenInputIsNotANumber_ShouldWriteErrorMessage()
        {
            // Arrange
            StringWriter output = new StringWriter();
            TextWriter originalOut = Console.Out;
            TextReader originalIn = Console.In;

            Console.SetIn(new StringReader("x"));
            Console.SetOut(output);

            try
            {
                // Act
                Number.IsEvenOrOdd();
            }
            catch (Exception)
            {
            }
            finally
            {
                Console.SetOut(originalOut);
                Console.SetIn(originalIn);
            }

            // Assert
            Assert.That(output.ToString(), Does.Contain("Wpisano błędną wartość lub nie wpisano jej wcale."));
        }
    }
}
