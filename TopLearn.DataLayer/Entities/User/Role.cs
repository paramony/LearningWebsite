using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TopLearn.DataLayer.Entities.User
{
   public class Role
    {
        public Role()
        {

        }
        [Key]
        public int RoleId { get; set; }

        [Display(Name ="عنوان نقش")]
        [Required(ErrorMessage ="لطفا {0} را وارد نمایید.")]
        [MaxLength(200,ErrorMessage ="{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Title { get; set; }
        public bool IsDelete { get; set; }

        public virtual List<UserRole> UserRoles { get; set; }
        public List<Permission.RolePermission> RolePermissions { get; set; }
    }
}
