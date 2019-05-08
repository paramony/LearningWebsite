using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.Services.Interfaces;

namespace TopLearn.Web.Pages.Admin.CourseGroups
{
    public class IndexModel : PageModel
    {
        private readonly ICourseService _courseService;
        public IndexModel(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public List<TopLearn.DataLayer.Entities.Course.CourseGroup> CourseGroups { get; set; }
        public void OnGet()
        {
            CourseGroups = _courseService.GetAllGroup();
        }
    }
}