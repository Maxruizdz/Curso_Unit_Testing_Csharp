using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace StringManipulation.Test
{
    public class StringOperationsTest
    {
        [Fact(Skip ="Esta prueba no es valida en este momento Ticket-0001")]
        public void ConcatenateStrings()
        {   //Arrange
            var StringOperation = new StringOperations();
            //Act
            var result = StringOperation.ConcatenateStrings("Hello", "Word");
            //Assert
            Assert.NotEmpty(result);
            Assert.NotNull(result);
            Assert.Equal("Hello Word", result);
        }
        [Theory]
        [InlineData("ama", true)]
        [InlineData("futbol", false)]
     

        public void IsPalindrome(string palabra, bool expected) {

            var StringOperation = new StringOperations();
            //Act
            var result = StringOperation.IsPalindrome(palabra);
            //Assert
            Assert.Equal(expected, result);


        }
        
        [Fact]

        public void QuantintyInWords() {

            //Arrange
            var StringOperation = new StringOperations();
            //Act
            var result = StringOperation.QuantintyInWords("cat", 10);

            //Assert
            Assert.StartsWith("diez", result);
            Assert.Contains("cat", result);

        }
        [Fact]
        public void GetStringLength_Exception() {


            var StringOperation = new StringOperations();

            Assert.ThrowsAny<ArgumentNullException>(() => StringOperation.GetStringLength(null));

        }

        [Fact]
        public void TruncateString_Exception() {


            var StringOperation = new StringOperations();


            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => StringOperation.TruncateString("Futbol", 0));



        }
        [Theory]
        [InlineData("V", 5)]
        [InlineData("X" ,10)]
        [InlineData("III", 3)]
        public void FromRomanToNumber(string roman_Number, int expected) {


            var StringOperation = new StringOperations();

            var result = StringOperation.FromRomanToNumber(roman_Number);

            Assert.Equal(expected, result);



        }
        [Fact]
        public void CountOccurrences() {
            var MockLogger= new Mock<ILogger<StringOperations>>();
            var StringOperation = new StringOperations(MockLogger.Object);

            var result = StringOperation.CountOccurrences("Hello Word", 'l');


            Assert.Equal(2, result);

        }
    }
}
