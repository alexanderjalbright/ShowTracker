using NSubstitute;
using ShowTracker.Controllers;
using ShowTracker.Models;
using ShowTracker.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace ShowTracker.Tests
{
    public class ShowControllerTests
    {
        ShowController underTest;
        IShowRepository repo;

        public ShowControllerTests()
        {
            repo = Substitute.For<IShowRepository>();

            underTest = new ShowController(repo);
        }

        [Fact]
        public void Get_Returns_A_Show()
        {
            var expectedId = 1;
            repo.GetById(expectedId).Returns(new Show() { ShowId = expectedId });

            var result = underTest.Get(expectedId);

            Assert.Equal(expectedId, result.Value.ShowId);
        }

        [Fact]
        public void Post_Creates_Show()
        {
            var result = underTest.Post(new Show());

            Assert.True(result.Value);
        }

        [Fact]
        public void Post_Updates_Show()
        {
            var result = underTest.Post(1, new Show());

            Assert.True(result.Value);
        }

        [Fact]
        public void Post_Deletes_Show()
        {
            var result = underTest.Delete(1);

            Assert.True(result.Value);
        }
    }
}
