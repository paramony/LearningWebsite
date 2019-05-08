using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearn.Web.Pages.Admin.Courses
{
    public class EditCourseModel : PageModel
    {
        private readonly ICourseService _courseService;
        public EditCourseModel(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [BindProperty]
        public Course Course { get; set; }
        public void OnGet(int id)
        {
            Course = _courseService.GetCourseById(id);
            var groups = _courseService.GetGroupForManageCourse();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text",Course.GroupId);
            var subGroup = _courseService.GetSubGroupForManageCourse(_courseService.GetSelectedGroupByCourseId(id));
            ViewData["SubGroups"] = new SelectList(subGroup, "Value", "Text",Course.SubGroup??0);
            var teacher = _courseService.GetTeachers();
            ViewData["Teachers"] = new SelectList(teacher, "Value", "Text",Course.TeacherId);
            var levels = _courseService.GetLevels();
            ViewData["Levels"] = new SelectList(levels, "Value", "Text",Course.LevelId);
            var status = _courseService.GetStatuses();
            ViewData["Status"] = new SelectList(status, "Value", "Text",Course.StatusId);
        }
        public IActionResult OnPost(IFormFile imgCourseUp,IFormFile demoUp)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _courseService.UpdateCourse(Course, imgCourseUp, demoUp);
            return RedirectToPage("Index");
        }
    }
}