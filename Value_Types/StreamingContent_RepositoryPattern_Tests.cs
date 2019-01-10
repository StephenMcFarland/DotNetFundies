using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPattern;

namespace Value_Types
{
    [TestClass]
    public class StreamingContent_RepositoryPattern_Tests
    {
        [TestMethod]
        public void StreamingContent_SetTitle_ShouldBeCorrectString()
        {
            //--Arrange
            StreamingContent movie = new StreamingContent();
            movie.ContentTitle = "Infinity Wars";
            //--Act
            string actual = movie.ContentTitle;
            string expected = "Infinity Wars";

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContent_SetIsMatureBoolean_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            content.IsMature = true;
            //Act
            bool actual = content.IsMature;
            bool expected = true;
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void StreamingContent_Constructor_ShouldHoldCorrectValues()
        {
            //Arrange
            StreamingContent content = new StreamingContent("Bolt", "Family", 1.3f, false, 5);

            //Act
            string actual = content.ContentTitle;
            string expected = "Bolt";

            bool actualOne = content.IsMature;
            bool expectedOne = false;

            //Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedOne, actualOne);
        }

        [TestMethod]
        public void StreamingContentRepository_AddToList_ShouldReturnCorrectCount()
        {
            //Arrange
            StreamingContent content = new StreamingContent("hello", "horror", 1.3f, false, 5);
            StreamingContent contentTwo = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();

            //Act
            repo.AddContentToList(content);
            repo.AddContentToList(contentTwo);

            int actual = repo.GetStreamingContentList().Count;
            int expected = 2;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
