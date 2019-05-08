using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TopLearn.DataLayer.Entities.Course
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        public int GroupId { get; set; }

        public int? SubGroup { get; set; }

        [Required]
        public int TeacherId { get; set; }

        [Required]
        public int StatusId { get; set; }

        [Required]
        public int LevelId { get; set; }

        [Display(Name = "عنوان دوره")]
        [MaxLength(450, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید")]
        public string CourseTitle { get; set; }

        [Display(Name = "شرح دوره")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید")]
        public string CourseDescription { get; set; }

        [Display(Name = "قیمت دوره")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید")]
        public int CoursePrice { get; set; }

        [Display(Name = "کلمات کلیدی")]
        [MaxLength(600, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Tags { get; set; }

        [Display(Name = "عکس دوره")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string CourseImageName { get; set; }

        [Display(Name = "پیش نمایش دوره")]
        [MaxLength(100, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string DemoFileName { get; set; }

        [Display(Name = "زمان ایجاد دوره")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید")]
        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        [ForeignKey("TeacherId")]
        public User.User User { get; set; }

        [ForeignKey("GroupId")]
        public CourseGroup CourseGroup { get; set; }

        [ForeignKey("SubGroup")]
        public CourseGroup Group { get; set; }
        public CourseStatus CourseStatus { get; set; }
        public CourseLevel CourseLevel { get; set; }
        public List<CourseEpisode> CourseEpisodes { get; set; }
        public List<Order.OrderDetail> OrderDetails { get; set; }
        public List<UserCourse> UserCourses { get; set; }
        public List<CourseComment> CourseComments { get; set; }
    }
}
