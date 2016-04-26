using Risk;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RiskTest
{
    
    
    /// <summary>
    ///This is a test class for UnitTest and is intended
    ///to contain all UnitTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UnitTest
    {
        Unit testUnit;

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
        [TestInitialize()]
        public void MyTestInitialize()
        {
            
        }
        
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        public void MyTestCleanup()
        {
            testUnit = null;
        }
        
        #endregion


        /// <summary>
        ///A test for UnitType
        ///</summary>
        [TestMethod()]
        public void UnitTypeTest()
        {
            testUnit = new Unit();

            Assert.AreEqual(0, testUnit.UnitType);

            testUnit.UnitType = 5;

            Assert.AreNotEqual(0, testUnit.UnitType);
            Assert.AreEqual(5, testUnit.UnitType);

        }

        /// <summary>
        ///A test for UnitStrength
        ///</summary>
        [TestMethod()]
        public void UnitStrengthTest()
        {
            testUnit = new Unit();

            Assert.AreEqual(0,testUnit.UnitStrength);

            testUnit.UnitStrength = 5;

            Assert.AreNotEqual(0,testUnit.UnitStrength);
            Assert.AreEqual(5,testUnit.UnitStrength);


        }

        /// <summary>
        ///A test for Unit Constructor
        ///</summary>
        [TestMethod()]
        public void UnitConstructorTest()
        {
            Assert.AreEqual(null,testUnit);

            testUnit = new Unit();

            Assert.AreNotEqual(null, testUnit);
        
        }
    }
}
