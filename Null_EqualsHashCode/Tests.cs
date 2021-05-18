using System.Collections.Generic;
using Xunit;

namespace Null_EqualsHashCode
{
    public class Tests
    {
        [Fact]
        public void DateTest()
        {
            var date = new Date(18, 5);
            
            var set = new HashSet<Date>();
            set.Add(date);
            
            var sameDate = new Date(18, 5);
            Assert.Equal(date, sameDate);
            
            Assert.True(set.Contains(date));
            Assert.False(set.Contains(sameDate));
        }
    }
}