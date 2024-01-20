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
        [Fact]
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
        [Fact] 
        public void IsPalindromeTrue(){

            var StringOperation = new StringOperations();
            //Act
            var result = StringOperation.IsPalindrome("ama");
            //Assert
            Assert.True(result);
         }

        public void IsPalindromeFalse()
        {
            //Arrange
            var StringOperation = new StringOperations();
            //Act
            var result = StringOperation.IsPalindrome("Futbol");
            //Assert
            Assert.False(result);
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

            Assert.ThrowsAny<ArgumentNullException>(()=>StringOperation.GetStringLength(null));

        }

        [Fact]
        public void TruncateString_Exception() {


            var StringOperation = new StringOperations();

           
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => StringOperation.TruncateString("Futbol", 0) );



        }
    }
}
