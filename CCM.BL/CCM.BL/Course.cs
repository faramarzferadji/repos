using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCM.BL
{
   public class Course
    {
        public Course()//defult constructor
        {

        }
        public Course( int courseId)
        {
            CourseId = courseId;

        }
        public int CourseId { get; private set; }
        public string CourseTitle { get; set; }
        public  DateTimeOffset? CourseHours { get; set; }
        public string CourseDiscription { get; set; }

        public bool ValidCourse()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(CourseTitle)) isValid = false;
            if (string.IsNullOrWhiteSpace(CourseDiscription)) isValid = false;
            return isValid;
        }
    }
}


