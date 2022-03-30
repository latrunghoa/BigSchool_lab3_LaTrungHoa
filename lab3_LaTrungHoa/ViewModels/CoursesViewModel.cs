using lab3_LaTrungHoa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab3_LaTrungHoa.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}