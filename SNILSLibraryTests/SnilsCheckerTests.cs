using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SNILSLibrary;

namespace SNILSLibraryTests
{
    [TestClass]
    public class SnilsCheckerTests
    {

        [DataTestMethod]
        [DataRow("112-233-445 95")]
        [DataRow("15795916329")]
        [DataRow("20401330880")]
        [DataRow("17611432955")]
        [DataRow("19160771478")]
        [DataRow("16570395587")]
        [DataRow("17838689649")]
        [DataRow("16992402305")]
        [DataRow("20398397186")]
        [DataRow("19978255360")]
        [DataRow("16067055052")]
        [DataRow("20043715906")]
        [DataRow("20874913181")]
        [DataRow("15955163599")]
        [DataRow("19596091835")]
        [DataRow("19596091835")]
        [DataRow("15974550714")]
        [DataRow("20208120183")]
        [DataRow("20149847051")]
        [DataRow("17460248064")]
        [DataRow("20057830427")]
        [DataRow("20508756552")]


        public void AllTests(string str)
        {
            SnilsChecker checker = new SnilsChecker();

            bool actual = checker.CheckPersonakCode(str);

            Assert.IsTrue(actual);
        }
       /// <summary>
       ///  Пустая строка - false
       /// </summary>
       
        [TestMethod]
        public void CheckPersonakCode_SnilsEmpty_ReturnedFalse()
        {
            string snils = "";

            SnilsChecker checker = new SnilsChecker();

            bool actual = checker.CheckPersonakCode(snils);

            Assert.IsFalse(actual);
        }

        // <summary>
        ///  112-233-445 97 - false
        /// </summary>

        [TestMethod]
        public void CheckPersonakCode_11223344597_ReturnedFalse()
        {
            string snils = "112-233-445 97";

            SnilsChecker checker = new SnilsChecker();

            bool actual = checker.CheckPersonakCode(snils);

            Assert.IsFalse(actual);
        }

        // <summary>
        ///  Меньше 11 цифр - false
        /// </summary>
        
        [TestMethod]
        public void CheckPersonakCode_333_ReturnedFalse()
        {
            string snils = "333";

            SnilsChecker checker = new SnilsChecker();

            bool actual = checker.CheckPersonakCode(snils);

            Assert.IsFalse(actual);
        }

        // <summary>
        ///  Больше 11 цифр - false
        /// </summary>
        
        [TestMethod]
        public void CheckPersonakCode_999999999999999999999_ReturnedFalse()
        {
            string snils = "999999999999999999999";

            SnilsChecker checker = new SnilsChecker();

            bool actual = checker.CheckPersonakCode(snils);

            Assert.IsFalse(actual);
        }

        //public void CheckPersonakCode_11223344595_ReturnedTrue()
        //{
        //    string snils = "112-233-445 95";

        //    SnilsChecker checker = new SnilsChecker();

        //    bool actual = checker.CheckPersonakCode(snils);

        //    Assert.IsTrue(actual);
        //}





        //[TestMethod]
        //public void CheckPersonakCode_15795916329_ReturnedTrue()
        //{
        //    string snils = "15795916329";

        //    SnilsChecker checker = new SnilsChecker();

        //    bool actual = checker.CheckPersonakCode(snils);

        //    Assert.IsTrue(actual);
        //}

        //[TestMethod]
        //public void CheckPersonakCode_20401330880_ReturnedTrue()
        //{
        //    string snils = "20401330880";

        //    SnilsChecker checker = new SnilsChecker();

        //    bool actual = checker.CheckPersonakCode(snils);

        //    Assert.IsTrue(actual);
        //}

        //[TestMethod]
        //public void CheckPersonakCode_17611432955_ReturnedTrue()
        //{
        //    string snils = "17611432955";

        //    SnilsChecker checker = new SnilsChecker();

        //    bool actual = checker.CheckPersonakCode(snils);

        //    Assert.IsTrue(actual);
        //}

        //[TestMethod]
        //public void CheckPersonakCode_19160771478_ReturnedTrue()
        //{
        //    string snils = "19160771478";

        //    SnilsChecker checker = new SnilsChecker();

        //    bool actual = checker.CheckPersonakCode(snils);

        //    Assert.IsTrue(actual);
        //}

        //[TestMethod]
        //public void CheckPersonakCode_16570395587_ReturnedTrue()
        //{
        //    string snils = "16570395587";

        //    SnilsChecker checker = new SnilsChecker();

        //    bool actual = checker.CheckPersonakCode(snils);

        //    Assert.IsTrue(actual);
        //}

        //[TestMethod]
        //public void CheckPersonakCode_17838689649_ReturnedTrue()
        //{
        //    string snils = "17838689649";

        //    SnilsChecker checker = new SnilsChecker();

        //    bool actual = checker.CheckPersonakCode(snils);

        //    Assert.IsTrue(actual);
        //}
    }

}
