using HW1c.Models;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        [TestMethod]
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ReportViewModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Get_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();

            // Act
            var result = myTest.NumberOfUsers;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Set_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();

            // Act
             myTest.NumberOfUsers = 5;

            // Assert
            Assert.AreEqual(5, myTest.NumberOfUsers);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Get_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();

            // Act
            var result = myTest.LogViewModel;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Set_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();
            var myLogView = new LogViewModel();
            var myList = new List<LogModel>();
            myList.Add(new LogModel { PhoneID = "myPhone" });
            myLogView.LogList = myList;

            // Act
            myTest.LogViewModel = myLogView;

            // Assert
            Assert.AreEqual("myPhone", myTest.LogViewModel.LogList[0].PhoneID);
        }
    }
}
