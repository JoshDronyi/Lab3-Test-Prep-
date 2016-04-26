using Risk;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace RiskTest
{
    
    
    /// <summary>
    ///This is a test class for ArmyTest and is intended
    ///to contain all ArmyTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ArmyTest
    {
        Army testArmy;


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Army Constructor
        ///</summary>
        [TestMethod()]
        public void ArmyConstructorTest()
        {
            Army target = new Army();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AddArtillary
        ///</summary>
        [TestMethod()]
        public void AddArtillaryTest()
        {
            Army target = new Army(); // TODO: Initialize to an appropriate value
            target.AddArtillary();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddCalvary
        ///</summary>
        [TestMethod()]
        public void AddCalvaryTest()
        {
            Army target = new Army(); // TODO: Initialize to an appropriate value
            target.AddCalvary();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddInfantry
        ///</summary>
        [TestMethod()]
        public void AddInfantryTest()
        {
            Army target = new Army(); // TODO: Initialize to an appropriate value
            target.AddInfantry();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for BreakArtillary
        ///</summary>
        [TestMethod()]
        public void BreakArtillaryTest()
        {
            Army target = new Army(); // TODO: Initialize to an appropriate value
            List<Unit> expected = null; // TODO: Initialize to an appropriate value
            List<Unit> actual;
            actual = target.BreakArtillary();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BreakCalvary
        ///</summary>
        [TestMethod()]
        public void BreakCalvaryTest()
        {
            Army target = new Army(); // TODO: Initialize to an appropriate value
            List<Unit> expected = null; // TODO: Initialize to an appropriate value
            List<Unit> actual;
            actual = target.BreakCalvary();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetStrength
        ///</summary>
        [TestMethod()]
        public void StrengthTest()
        {
            testArmy = new Army();

            Assert.AreNotEqual(null, testArmy);

            Assert.AreEqual(1,testArmy.Strength);

            testArmy.AddArtillary();

            Assert.AreEqual(11,testArmy.Strength);
            
            



        }

        /// <summary>
        ///A test for SubtractInfantry
        ///</summary>
        [TestMethod()]
        public void SubtractInfantryTest()
        {
            Army target = new Army(); // TODO: Initialize to an appropriate value
            target.SubtractInfantry();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
