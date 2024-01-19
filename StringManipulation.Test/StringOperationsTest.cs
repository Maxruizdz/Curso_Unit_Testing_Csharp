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
        {
            var StringOperation = new StringOperations();

            var result = StringOperation.ConcatenateStrings("Hello", "Word");

            Assert.Equal("HelloWord", result);
        }

    }
}
