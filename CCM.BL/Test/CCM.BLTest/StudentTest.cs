using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CCM.BL;

namespace CCM.BLTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentName()
        {
            Student student = new Student();
            student.StudentName = "Bibi";
            string expected = "Bibi";
            string actuel = student.StudentName;
            Assert.AreEqual(expected, actuel);

        }
        [TestMethod]
        public void StudentEmail()
        {
            Student student = new Student();
            student.StudentEmail = "Bibi@.ca";
            string expected = "Bibi@.ca";
            string actuel = student.StudentEmail;
            Assert.AreEqual(expected, actuel);

        }
        [TestMethod]
        public void StudentHomeAddress()
        {
            Student student = new Student();
            student.StudentHomeAddress = "89 fara avenue";
            string expected = "89 fara avenue";
            string actuel = student.StudentHomeAddress;
            Assert.AreEqual(expected, actuel);

        }
        [TestMethod]
        public void ValidValidation()
        {
            Student student = new Student
            {
                StudentName ="bibi",
                StudentEmail ="bibi @h.ca"

            };
            var expected = true;
            var actuel = student.Validate();
            Assert.AreEqual(expected, actuel);
            
        }
    }
}
