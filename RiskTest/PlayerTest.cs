using Risk;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace RiskTest
{
    
    
    /// <summary>
    ///This is a test class for PlayerTest and is intended
    ///to contain all PlayerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PlayerTest
    {


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
        ///A test for Player Constructor
        ///</summary>
        [TestMethod()]
        public void PlayerConstructorTest()
        {
            Player target = new Player();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Player Constructor
        ///</summary>
        [TestMethod()]
        public void PlayerConstructorTest1()
        {
            string n = string.Empty; // TODO: Initialize to an appropriate value
            int h = 0; // TODO: Initialize to an appropriate value
            bool a = false; // TODO: Initialize to an appropriate value
            Player target = new Player(n, h, a);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Attack
        ///</summary>
        [TestMethod()]
        public void AttackTest()
        {
            Player target = new Player(); // TODO: Initialize to an appropriate value
            int[] expected = null; // TODO: Initialize to an appropriate value
            int[] actual;
            actual = target.Attack();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Defend
        ///</summary>
        [TestMethod()]
        public void DefendTest()
        {
            Player target = new Player(); // TODO: Initialize to an appropriate value
            int[] expected = null; // TODO: Initialize to an appropriate value
            int[] actual;
            actual = target.Defend();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fortify
        ///</summary>
        [TestMethod()]
        public void FortifyTest()
        {
            Player target = new Player(); // TODO: Initialize to an appropriate value
            Territory t = null; // TODO: Initialize to an appropriate value
            int fortifications = 0; // TODO: Initialize to an appropriate value
            target.Fortify(t, fortifications);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Owns
        ///</summary>
        [TestMethod()]
        public void OwnsTest()
        {
            Player target = new Player(); // TODO: Initialize to an appropriate value
            Territory t = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Owns(t);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Reinforce
        ///</summary>
        [TestMethod()]
        public void ReinforceTest()
        {
            Player target = new Player(); // TODO: Initialize to an appropriate value
            Army a = null; // TODO: Initialize to an appropriate value
            Unit u = null; // TODO: Initialize to an appropriate value
            target.Reinforce(a, u);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ArmyList
        ///</summary>
        [TestMethod()]
        public void ArmyListTest()
        {
            Player target = new Player(); // TODO: Initialize to an appropriate value
            List<Army> expected = null; // TODO: Initialize to an appropriate value
            List<Army> actual;
            target.ArmyList = expected;
            actual = target.ArmyList;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HomeTerritory
        ///</summary>
        [TestMethod()]
        public void HomeTerritoryTest()
        {
            Player target = new Player(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.HomeTerritory = expected;
            actual = target.HomeTerritory;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            Player target = new Player(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Name = expected;
            actual = target.Name;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for playerTerritories
        ///</summary>
        [TestMethod()]
        public void playerTerritoriesTest()
        {
            Player target = new Player(); // TODO: Initialize to an appropriate value
            List<Territory> expected = null; // TODO: Initialize to an appropriate value
            List<Territory> actual;
            target.playerTerritories = expected;
            actual = target.playerTerritories;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
