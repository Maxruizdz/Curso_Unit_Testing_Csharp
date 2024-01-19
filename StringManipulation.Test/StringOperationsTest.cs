using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            var StringOperation = new StringOperations();
            //Act
            var result = StringOperation.IsPalindrome("Futbol");
            //Assert
            Assert.False(result);
        }

    }
}
