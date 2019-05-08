using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Web.Pages.Admin.Roles
{
    [PermissionChecker(8)]
    public class EditRoleModel : PageModel
    {
        private readonly IPermissionService _permissionService;
        public EditRoleModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        [BindProperty]
        public Role Role { get; set; }
        public void OnGet(int id)
        {
            Role = _permissionService.GetRoleById(id);
            ViewData["Permission"] = _permissionService.GetAllPermission();
            ViewData["SelectedPermission"] = _permissionService.PermissionRole(id);
        }
        public IActionResult OnPost(List<int> SelectedPermission)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _permissionService.UpdateRole(Role);
            _permissionService.UpdatePermissionRole(Role.RoleId, SelectedPermission);
            return RedirectToPage("Index");
        }
    }
}