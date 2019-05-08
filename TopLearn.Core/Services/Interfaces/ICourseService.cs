using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.Core.DTOs.Course;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearn.Core.Services.Interfaces
{
    public interface ICourseService
    {
        #region Group
        List<CourseGroup> GetAllGroup();
        List<SelectListItem> GetGroupForManageCourse();
        List<SelectListItem> GetSubGroupForManageCourse(int groupId);
        List<SelectListItem> GetTeachers();
        List<SelectListItem> GetLevels();
        List<SelectListItem> GetStatuses();
        CourseGroup GetGroupById(int groupId);
        void AddGroup(CourseGroup group);
        void UpdateGroup(CourseGroup group);
        #endregion

        #region Course

        List<ShowCourseForAdminViewModel> GetCoursesForAdmin();
        int AddCourse(Course course, IFormFile imgCourse, IFormFile courseDemo);
        Course GetCourseById(int courseId);
        void UpdateCourse(Course course, IFormFile imgCourse, IFormFile courseDemo);
        int GetSelectedGroupByCourseId(int courseId);
        List<ShowCourseListItemViewModel> GetPopularCourse();
        #endregion

        #region Episode
        int AddEpisode(CourseEpisode episode, IFormFile episodeFile);
        bool CheckExistFile(string fileName);
        List<CourseEpisode> GetListEpisodeCourse(int courseId);
        CourseEpisode GetEpisodeById(int episodeId);
        void EditEpisode(CourseEpisode episode, IFormFile episodeFile);
        Tuple<List<ShowCourseListItemViewModel>,int> GetCourse(int pageId = 1, string filter = "", string getType = "all", string orderByType = "date", int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null, int take = 0);

        Course GetCourseForShow(int courseId);

        #endregion

        #region Comment
        void AddComment(CourseComment comment);
        Tuple<List<CourseComment>,int> GetCourseComment(int courseId,int pageId=1);
        #endregion
    }
}
