using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        
        [Fact]
        public void SearchReturnsFullMenuIfNull()
        {
            string t = null;
            IEnumerable<IOrderItem> res = Menu.Search(t);
            Assert.Equal<IEnumerable<IOrderItem>>(res, Menu.FullMenu());
        }
    }
}
