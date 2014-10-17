using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StateTestsLib
{
    [TestClass]
    public class ClockSetupTests
    {
        [TestMethod]
        public void Test_That_ClockSetup_Returns_Correct_Date()
        {
            // Arrange
            // The initial date in ClockSetup should be 15th march 2011
            DateTime expectedDate = new DateTime(2012, 4, 14, 0, 0, 0);
            ClockSetup setup = new ClockSetup();
            setup.YearState = new YearState(setup, 2011);
            setup.MonthState = new MonthState(setup, 3);
            setup.DayState = new DayState(setup, 15);
            // Act
            setup.PushKnob();
            setup.RotateRight();
            setup.PushKnob();
            setup.RotateRight();
            setup.PushKnob();
            setup.RotateLeft();
            setup.PushKnob();
            // Assert
            Assert.AreEqual(expectedDate, setup.GetSelectedDate());
        }
    }
}
