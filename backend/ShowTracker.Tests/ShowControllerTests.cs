using ShowTracker.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace ShowTracker.Tests
{
    public class ShowControllerTests
    {
        [Fact]
        public void Get_Returns_All_Shows()
        {
            var undertest = new ShowController();

            var result = undertest.Get();

            Assert.Equal(2, result.Value.Count());
        }
    }
}
