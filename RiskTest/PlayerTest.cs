using Risk;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections;

namespace RiskTest
{
    
    
    /// <summary>
    ///This is a test class for PlayerTest and is intended
    ///to contain all PlayerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PlayerTest
    {
        Player pdawg;


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
        [TestCleanup()]
        public void MyTestCleanup()
        {
            pdawg = null;
        }
        
        #endregion


        /// <summary>
        ///A test for Player Constructor
        ///</summary>
        [TestMethod()]
        public void PlayerConstructorTest()
        {
            pdawg = new Player();
            Assert.AreEqual(null,pdawg.ArmyList);
            Assert.AreEqual(null,pdawg.Alive);
            Assert.AreEqual(null, pdawg.Name);
            Assert.AreEqual(0,pdawg.HomeTerritory);

        }

        /// <summary>
        ///A test for Player Constructor
        ///</summary>
        [TestMethod()]
        public void PlayerConstructorTest1()
        {
            pdawg = new Player();
            string name = "pdawg";
            int home = 12;
            List<Army> ArmyList = new List<Army>();
            ArmyList.Add(new Army());
            bool alive = false;

            pdawg.Name = name;
            pdawg.HomeTerritory = home;
            pdawg.ArmyList = ArmyList;
            pdawg.Alive = alive;


            Assert.AreSame(ArmyList, pdawg.ArmyList);
            Assert.AreEqual(1,pdawg.ArmyList.Count);
            Assert.AreEqual(alive, pdawg.Alive);
            Assert.AreEqual(name, pdawg.Name);
            Assert.AreEqual(home, pdawg.HomeTerritory);
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
            pdawg = new Player();

            Assert.AreNotEqual(null, pdawg);
            Assert.AreEqual(null,pdawg.ArmyList);

            Army AfricaArmy = new Army();
            Army NAmericaArmy = new Army();
            Army SAmericaArmy = new Army();
            Army EuropeArmy = new Army();

            pdawg.ArmyList.Add(AfricaArmy);
            pdawg.ArmyList.Add(NAmericaArmy);
            pdawg.ArmyList.Add(SAmericaArmy);
            pdawg.ArmyList.Add(EuropeArmy);

            Assert.AreEqual(4,pdawg.ArmyList.Count);




        }

        /// <summary>
        ///A test for HomeTerritory
        ///</summary>
        [TestMethod()]
        public void HomeTerritoryTest()
        {
            pdawg = new Player();

            Assert.AreNotEqual(null, pdawg);
            Assert.AreEqual(null, pdawg.HomeTerritory);

            pdawg.HomeTerritory = 3;

            Assert.AreEqual(3,pdawg.HomeTerritory);


        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            pdawg = new Player();

            Assert.AreNotEqual(null, pdawg);
            Assert.AreEqual(null, pdawg.Name);

            pdawg.Name = "pdawg";

            Assert.AreEqual("pdawg",pdawg.Name);
        }

        /// <summary>
        ///A test for playerTerritories
        ///</summary>
        [TestMethod()]
        public void playerTerritoriesTest()
        {
            pdawg = new Player();
            Assert.AreNotEqual(null, pdawg);
            Assert.AreEqual(0,pdawg.playerTerritories.Count);


            pdawg.playerTerritories.Add(new Territory("Africa"));
            pdawg.playerTerritories.Add(new Territory("North America"));
            pdawg.playerTerritories.Add(new Territory("South America"));
            pdawg.playerTerritories.Add(new Territory("Europe"));


            Assert.AreEqual(4,pdawg.playerTerritories.Count);
            Assert.AreEqual("Africa", pdawg.playerTerritories[0]);
            Assert.AreEqual("North America", pdawg.playerTerritories[0]);
            Assert.AreEqual("South America", pdawg.playerTerritories[0]);
            Assert.AreEqual("Europe", pdawg.playerTerritories[0]);

        }
    }
}
