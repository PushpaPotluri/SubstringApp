using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _10SubstringApp;

namespace _10SubstringAppTests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void GetAll10SubstringsSuccess()
        {
            // Arrange
            string number = "100";

            // Act
            var list10Substring = Program.GetAll10Substrings(number).Result;

            // Assert
            Assert.IsTrue(list10Substring.Any());
        }

        [TestMethod]
        public void GetAll10SubstringsZeroNumberSuccess()
        {
            // Arrange
            string number = "0";

            // Act
            var list10Substring = Program.GetAll10Substrings(number).Result;

            // Assert
            Assert.IsFalse(list10Substring.Any());
        }

        [TestMethod]
        public void GetAll10SubstringsInvalidNumberFail()
        {
            // Arrange
            string number = "ACD42";

            // Act
            var list10Substring = Program.GetAll10Substrings(number).Result;

            // Assert
            Assert.IsFalse(list10Substring.Any());
        }

        [TestMethod]
        public void Is10SubstringsSuccess()
        {
            // Arrange
            string number = "3523014";

            // Act
            var result = Program.Is10Substring(number).Result;

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Is10SubstringsFail()
        {
            // Arrange
            string number = "28546";

            // Act
            var result = Program.Is10Substring(number).Result;

            // Assert
            Assert.IsFalse(result);
        }
    }
}
