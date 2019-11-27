using Microsoft.VisualStudio.TestTools.UnitTesting;
using Regular_Expression;


namespace Regular_Expression.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        private Form1 form;

        public void setUp()
        {
            form = new Form1();
        }
        [TestMethod()]
        public void ValidNameTest()
        {
            string name1 = "Adam";

            Assert.AreEqual(true, form.ValidName(name1));
        }
    }
}