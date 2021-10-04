using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCM.BL
{
   public class Grades
    {
        public string CourseId{ get; set; }
        public string StudentId { get; set; }
        public decimal? GradeNumGrade { get; set; }
        public DateTimeOffset? GradeDate { get; set; }

        public bool ValidateGrade()
        {
            var isValid = true;
            if (GradeDate == null) isValid = false;
            return isValid;
        }
    }
}
