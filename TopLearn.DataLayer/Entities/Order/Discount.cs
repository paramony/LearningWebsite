using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.DataLayer.Entities.Order
{
    public class Discount
    {
        [Key]
        public int DiscountId { get; set; }

        [Display(Name = "کد تخفیف")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string DiscountCode { get; set; }

        [Display(Name = "درصد تخفیف")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید")]
        public int Percent { get; set; }
        public int? UsableCount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public List<UserDiscountCode> UserDiscountCodes { get; set; }
    }
}
