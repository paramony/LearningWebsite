using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.DTOs;
using TopLearn.Core.Services.Interfaces;

namespace TopLearn.Web.Pages.Admin.Users
{
    public class ListDeleteUserModel : PageModel
    {

        private readonly IUserService _userService;
        public ListDeleteUserModel(IUserService userService)
        {
            _userService = userService;
        }
        public UserForAdminViewModel UserForAdminViewModel { get; set; }
        public void OnGet(int pageId = 1, string filterEmail = "", string filterUserName = "")
        {
            UserForAdminViewModel = _userService.GetDeleteUsers(pageId, filterEmail, filterUserName);
        }
    }
}