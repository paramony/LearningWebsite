﻿using System.ComponentModel.DataAnnotations;

namespace TopLearn.DataLayer.Entities.User
{
    public class UserRole
    {
        public UserRole()
        {

        }
        [Key]
        public int UR_Id { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }

        //Navigation Property
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
