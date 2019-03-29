using ShowTracker.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ShowTracker.Tests
{
    public class GenreModelTests
    {
        [Fact]
        public void Genre_Has_Name()
        {
            var undertest = new Genre() { Name = "Comedy" };

            var result = undertest.Name;

            Assert.Equal("Comedy", result);
        }

        [Fact]
        public void Genre_Has_Description()
        {
            var undertest = new Show() { Description = "Funny" };

            var result = undertest.Description;

            Assert.Equal("Funny", result);
        }      
    }
}
