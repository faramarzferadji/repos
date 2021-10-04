using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CCM.BL;

namespace CCM.BLTest
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CourseTitle()
        {
            Course course = new Course();
            course.CourseTitle = "Math";
            string expected = "Math";
            string actuel = course.CourseTitle;
            Assert.AreEqual(expected, actuel);
           
        }
        [TestMethod]
        public void CourseDescription()
        {
            Course course = new Course();
            course.CourseDiscription = "Math2 Request";

            string expected = "Math2 Request";
            string actuel = course.CourseDiscription;
            Assert.AreEqual(expected, actuel);

          
        }
        [TestMethod]
        public void ValidValidation()
        {
            Course course = new Course
            {
                CourseTitle = "Math",
                CourseDiscription = "Math1 request"
            };
            var expected = true;
            var actuel = course.ValidCourse();
            Assert.AreEqual(expected, actuel);
           
        }

       






    }
}
