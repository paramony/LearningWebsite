﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearn.Web.Pages.Admin.Courses
{
    public class CreateCourseModel : PageModel
    {
        private readonly ICourseService _courseService;
        public CreateCourseModel(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [BindProperty]
        public Course  Course { get; set; }
        public void OnGet()
        {
            var groups = _courseService.GetGroupForManageCourse();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text");
            var subGroup = _courseService.GetSubGroupForManageCourse(int.Parse(groups.First().Value));
            ViewData["SubGroups"] = new SelectList(subGroup, "Value", "Text");
            var teacher = _courseService.GetTeachers();
            ViewData["Teachers"] = new SelectList(teacher, "Value", "Text");
            var levels = _courseService.GetLevels();
            ViewData["Levels"] = new SelectList(levels, "Value", "Text");
            var status = _courseService.GetStatuses();
            ViewData["Status"] = new SelectList(status, "Value", "Text");
        }
        public IActionResult OnPost(IFormFile imgCourseUp,IFormFile demoUp)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _courseService.AddCourse(Course, imgCourseUp, demoUp);
            return RedirectToPage("Index");
            
        }
    }
}