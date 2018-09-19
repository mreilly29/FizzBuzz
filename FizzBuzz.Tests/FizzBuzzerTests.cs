using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        FizzBuzzer fizzBuzzer;

        [SetUp]
        public void SetUp()
        {
            fizzBuzzer = new FizzBuzzer();
        }

        [Test]
        public void Get_Returns_1_For_1()
        {

            string result = fizzBuzzer.Get(1);

            Assert.That(result, Is.EqualTo("1"));
        }

        [Test]
        public void Get_Returns_2_For_2()
        {

            string result = fizzBuzzer.Get(2);

            Assert.That(result, Is.EqualTo("2"));
        }

        [Test]
        public void Get_Returns_Fizz_For_3()
        {

            string result = fizzBuzzer.Get(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

       [Test]
       public void Get_Returns_Fizz_For_6()
        {
            string result = fizzBuzzer.Get(6);

            Assert.That(result, Is.EqualTo("Fizz"));
        }


        [TestCase(5, "Buzz")]
        [TestCase(10,"Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        public void Get_Returns_Expected(int input, string output)
        {
            string result = fizzBuzzer.Get(input);
            Assert.That(result, Is.EqualTo(output));
        }
    }
}
