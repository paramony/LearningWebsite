using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TopLearn.DataLayer.Entities.Course
{
    public class CourseEpisode
    {
        [Key]
        public int EpisodeId { get; set; }

        public int CourseId { get; set; }

        [Display(Name = "عنوان بخش")]
        [MaxLength(400, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید")]
        public string EpisodeTitle { get; set; }

        [Display(Name = "زمان")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید")]
        public TimeSpan EpisodeTime { get; set; }

        [Display(Name = "فایل")]
        public string EpisodeFileName { get; set; }

        [Display(Name = "رایگان")]
        public bool IsFree { get; set; }

        public Course Course { get; set; }
    }
}
