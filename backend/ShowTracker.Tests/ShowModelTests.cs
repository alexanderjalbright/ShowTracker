using ShowTracker.Models;
using System;
using Xunit;

namespace ShowTracker.Tests
{
    public class ShowModelTests
    {
        [Fact]
        public void Model_Has_Name()
        {
            var undertest = new Show() { Name = "Bobs Burgers" };

            var result = undertest.Name;

            Assert.Equal("Bobs Burgers", result);
        }

        [Fact]
        public void Model_Has_Description()
        {
            var undertest = new Show() { Description = "Restaurant cartoon" };

            var result = undertest.Name;

            Assert.Equal("Restaurant cartoon", result);
        }

        [Fact]
        public void Model_Has_Seasons()
        {
            var undertest = new Show() { Seasons = 5 };

            var result = undertest.Name;

            Assert.Equal("Restaurant cartoon", result);
        }
    }
}
