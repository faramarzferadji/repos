using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CCM.BL;

namespace CCM.BLTest
{
    [TestClass]
    public class GradeTest
    {
        [TestMethod]
        public void StudentId()
        {
            Grades grades = new Grades();
            grades.StudentId = "1245";
            string expected = "1245";
            string actuel = grades.StudentId;
            Assert.AreEqual(expected, actuel);
        }
        [TestMethod]
        public void CoursId()
        {
            Grades grades = new Grades();
            grades.CourseId = "91245";
            string expected = "91245";
            string actuel = grades.CourseId;
            
            Assert.AreEqual(expected, actuel);
        }
        [TestMethod]
        public void GradeNum()
        {
            Grades grades = new Grades();
            grades.GradeNumGrade = 85;
            string expected = "85";
            string actuel =Convert.ToString (grades.GradeNumGrade);

            Assert.AreEqual(expected, actuel);
        }
        [TestMethod]
        public void ValidGrade()
        {
            Grades grades = new Grades
            {
                GradeDate = null

            };
            var expected = false;
            var actuel = grades.GradeDate;
            Assert.AreEqual(expected, actuel);
        }

    }
}
