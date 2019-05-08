using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TopLearn.DataLayer.Entities.Wallet
{
    public class Wallet
    {
        public Wallet()
        {

        }
        [Key]
        public int WalletId { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {}  را وارد نمایید")]
        public int TypeId { get; set; }

        [Display(Name = "نوع تراکنش")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید")]
        public int UserId { get; set; }

        [Display(Name = "کاربر")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید")]
        public int Amount { get; set; }

        [Display(Name = "شرح")]
        public string Description { get; set; }

        [Display(Name = "تایید شده")]
        public bool IsPay { get; set; }

        [Display(Name = "تاریخ و ساعت")]
        public DateTime CreateDate { get; set; }

        public virtual User.User User { get; set; }
        public virtual WalletType WalletType { get; set; }
    }
}
