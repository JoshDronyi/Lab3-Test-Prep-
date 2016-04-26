using Risk;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RiskTest
{
    
    
    /// <summary>
    ///This is a test class for DieTest and is intended
    ///to contain all DieTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DieTest
    {
        Die testDie;

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
            testDie = null;
        }
        
        #endregion


        /// <summary>
        ///A test for Face
        ///</summary>
        [TestMethod()]
        public void FaceTest()
        {
            //Create Die instance
            testDie = new Die();

            //Set die to a specific number
            Random random = new Random();
            int testnum = random.Next(1, 6);
            testDie.Face = testnum;

            //Test if die was set
            Assert.AreNotEqual(null, testDie.Face);
            Assert.AreEqual(testnum,testDie.Face);

            //Repeat
            int oldNumber = testnum;
            testnum = random.Next(1,6);
            testDie.Face = testnum;

            Assert.AreNotEqual(oldNumber, testDie.Face);
            Assert.AreEqual(testnum,testDie.Face);

            oldNumber = testnum;
            testnum = random.Next(1, 6);
            testDie.Face = testnum;

            Assert.AreNotEqual(oldNumber, testDie.Face);
            Assert.AreEqual(testnum, testDie.Face);


        }

        /// <summary>
        ///A test for Die Constructor
        ///</summary>
        [TestMethod()]
        public void DieConstructorTest()
        {
            Assert.AreEqual(null,testDie);

            testDie = new Die();

            Assert.AreNotEqual(null, testDie);
        }
    }
}
