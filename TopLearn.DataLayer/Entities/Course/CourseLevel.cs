using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TopLearn.DataLayer.Entities.Course
{
    public class CourseLevel
    {
        [Key]
        public int LevelId { get; set; }

        [Display(Name = "سطح دوره")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string LevelType { get; set; }

        public List<Course> Courses { get; set; }
    }
}
