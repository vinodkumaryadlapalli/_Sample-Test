using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.UI.WebControls;
using Test_2022F.Models;
using Test_2022F.Services;

namespace Test_2022F.Tests.Services
{
    [TestClass]
    public class BookServiceTests
    {
        public TestContext TestContext { get; set; }

        private const string XML_PROVIDER = "Microsoft.VisualStudio.TestTools.DataSource.XML";

        [TestMethod]
        [DataSource(XML_PROVIDER, @"|DataDirectory|\XML\TestData.xml", "BookTest", DataAccessMethod.Sequential)]
        public void ItemServices_IsPublicDomain()
        {
            // Arrange
            bool expectedResult =(bool) TestContext.DataRow["ExpectedResult"]; // TestNote: Get the expected results from the XML
            Book b1 = new Book { 
                Title = "Test", 
                Edition = 1, 
                Published = (DateTime)TestContext.DataRow["ExpectedResult"]// TestNote: Get the published date from the XML 
        };
            
            // Act
            bool actualResult = true; // TestNote: Run the IsPublicDomain from the BookService on the Book

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
