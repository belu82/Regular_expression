using Microsoft.VisualStudio.TestTools.UnitTesting;
using Regular_Expression;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Form1 form;

        public void SetUp()
        {
            form = new Form1();
        }
        [TestMethod]
        public void ValidPhoneTest()
        {
            string name1 = "Lala";

            Assert.AreEqual(true, form.ValidName(name1));
            
          
        }
    }
}
