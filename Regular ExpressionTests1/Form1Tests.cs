using Microsoft.VisualStudio.TestTools.UnitTesting;
using Regular_Expression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regular_Expression.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void ValidNameTest()
        {
            Form1 form = new Form1();
            string name1 = "Adam";
            string name2 = "Adam Adam";
            string name3 = "Adam666";
            Assert.AreEqual(true, form.ValidName(name1));
            Assert.AreEqual(true, form.ValidName(name2));
            Assert.AreEqual(false, form.ValidName(name3));

        }
        [TestMethod()]

        public void ValidPhoneTest()
        {
            Form1 form = new Form1();
            string phone1 = "123-123-1234";
            Assert.AreEqual(true, form.ValidPhone(phone1));
            string phone2 = "1233-12-23";
            Assert.AreEqual(false, form.ValidPhone(phone2));
        }

        [TestMethod()]
        public void ValidMailTest()
        {
            Form1 form = new Form1();
            string mail1 = "example@example.com";
            Assert.AreEqual(true, form.ValidMail(mail1));
            string mail2 = "example2@gmail.com";
            Assert.AreEqual(true, form.ValidMail(mail2));
            string mail3 = "exámplét@gmail.com";
            Assert.AreEqual(false, form.ValidMail(mail3));
        }
    }
}