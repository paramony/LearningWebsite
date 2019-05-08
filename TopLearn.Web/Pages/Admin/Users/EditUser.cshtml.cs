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
    [PermissionChecker(4)]
    public class EditUserModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly IPermissionService   _permissionService;
        public EditUserModel(IUserService userService,IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }
        [BindProperty]
        public EditUserViewModel EditUserViewModel { get; set; }
        public void OnGet(int id)
        {
            EditUserViewModel = _userService.GetUserForShowInEditMode(id);
            ViewData["Roles"] = _permissionService.GetRoles();
        }
        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _userService.EditUserFromAdmin(EditUserViewModel);
            _permissionService.EditRolesUser(SelectedRoles, EditUserViewModel.UserId);
            return RedirectToPage("Index");
        }
    }
}