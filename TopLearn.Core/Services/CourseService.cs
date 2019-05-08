using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TopLearn.Core.Convertors;
using TopLearn.Core.DTOs.Course;
using TopLearn.Core.Generator;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Context;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearn.Core.Services
{
    public class CourseService : ICourseService
    {
        private readonly TopLearnContext _context;
        public CourseService(TopLearnContext context)
        {
            _context = context;
        }

        #region Course
        public int AddCourse(Course course, IFormFile imgCourse, IFormFile courseDemo)
        {
            course.CreateDate = DateTime.Now;
            course.CourseImageName = "no-photo.jpg";
            if (imgCourse != null && imgCourse.IsImage())
            {
                course.CourseImageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(imgCourse.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Course/image", course.CourseImageName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgCourse.CopyTo(stream);
                }
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Course/thumb", course.CourseImageName);
                ImageConvertor imgResizer = new ImageConvertor();
                imgResizer.Image_resize(imagePath, thumbPath, 150);
            }
            if (courseDemo != null)
            {
                course.DemoFileName = NameGenerator.GenerateUniqCode() + Path.GetExtension(courseDemo.FileName);
                string demoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Course/demoes", course.DemoFileName);
                using (var stream = new FileStream(demoPath, FileMode.Create))
                {
                    courseDemo.CopyTo(stream);
                }
            }
            _context.Courses.Add(course);
            _context.SaveChanges();
            return course.CourseId;
        }

        public List<ShowCourseForAdminViewModel> GetCoursesForAdmin()
        {
            return _context.Courses.Select(c => new ShowCourseForAdminViewModel()
            {
                CourseId = c.CourseId,
                ImageName = c.CourseImageName,
                Title = c.CourseTitle,
                EpisodeCount = c.CourseEpisodes.Count
            }).ToList();
        }

        public Course GetCourseById(int courseId)
        {
            return _context.Courses.Find(courseId);
        }
        public void UpdateCourse(Course course, IFormFile imgCourse, IFormFile courseDemo)
        {
            course.UpdateDate = DateTime.Now;
            if (imgCourse != null && imgCourse.IsImage())
            {
                if (course.CourseImageName != "no-photo.jpg")
                {
                    string deleteImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Course/image", course.DemoFileName);
                    if (File.Exists(deleteImagePath))
                    {
                        File.Delete(deleteImagePath);
                    }
                    string deleteThumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Course/thumb", course.DemoFileName);
                    if (File.Exists(deleteThumbPath))
                    {
                        File.Delete(deleteThumbPath);
                    }
                }
                course.CourseImageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(imgCourse.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Course/image", course.CourseImageName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgCourse.CopyTo(stream);
                }
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Course/thumb", course.CourseImageName);
                ImageConvertor imgResizer = new ImageConvertor();
                imgResizer.Image_resize(imagePath, thumbPath, 150);
            }
            if (courseDemo != null)
            {
                if (course.DemoFileName != null)
                {
                    string demoDeletePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Course/demoes", course.DemoFileName);
                    if (File.Exists(demoDeletePath))
                    {
                        File.Delete(demoDeletePath);
                    }
                }
                course.DemoFileName = NameGenerator.GenerateUniqCode() + Path.GetExtension(courseDemo.FileName);
                string demoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Course/demoes", course.DemoFileName);
                using (var stream = new FileStream(demoPath, FileMode.Create))
                {
                    courseDemo.CopyTo(stream);
                }
            }
            _context.Courses.Update(course);
            _context.SaveChanges();
        }
        public Tuple<List<ShowCourseListItemViewModel>, int> GetCourse(int pageId = 1, string filter = "", string getType = "all", string orderByType = "date", int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null, int take = 0)
        {
            if (take == 0)
                take = 8;

            IQueryable<Course> result = _context.Courses;

            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(c => c.CourseTitle.Contains(filter) || c.Tags.Contains(filter) );
            }

            switch (getType)
            {
                case "all":
                    break;
                case "buy":
                    {
                        result = result.Where(c => c.CoursePrice != 0);
                        break;
                    }
                case "free":
                    {
                        result = result.Where(c => c.CoursePrice == 0);
                        break;
                    }

            }

            switch (orderByType)
            {
                case "date":
                    {
                        result = result.OrderByDescending(c => c.CreateDate);
                        break;
                    }
                case "updatedate":
                    {
                        result = result.OrderByDescending(c => c.UpdateDate);
                        break;
                    }
            }

            if (startPrice > 0)
            {
                result = result.Where(c => c.CoursePrice > startPrice);
            }

            if (endPrice > 0)
            {
                result = result.Where(c => c.CoursePrice < startPrice);
            }


            if (selectedGroups != null && selectedGroups.Any())
            {
                foreach (int groupId in selectedGroups)
                {
                    result = result.Where(c => c.GroupId == groupId || c.SubGroup == groupId);
                }

            }

            int skip = (pageId - 1) * take;

            int pageCount = result.Include(c => c.CourseEpisodes).Select(c => new ShowCourseListItemViewModel()
            {
                CourseId = c.CourseId,
                ImageName = c.CourseImageName,
                Price = c.CoursePrice,
                Title = c.CourseTitle,
                TotalTime = new TimeSpan(c.CourseEpisodes.Sum(e => e.EpisodeTime.Ticks))
            }).Count() / take;

            var query = result.Include(c => c.CourseEpisodes).Select(c => new ShowCourseListItemViewModel()
            {
                CourseId = c.CourseId,
                ImageName = c.CourseImageName,
                Price = c.CoursePrice,
                Title = c.CourseTitle,
                TotalTime = new TimeSpan(c.CourseEpisodes.Sum(e => e.EpisodeTime.Ticks))
            }).Skip(skip).Take(take).ToList();

            return Tuple.Create(query, pageCount);
        }

        public Course GetCourseForShow(int courseId)
        {
            return _context.Courses
                           .Include(c => c.CourseEpisodes)
                           .Include(c => c.CourseStatus)
                           .Include(c => c.CourseLevel)
                           .Include(c => c.User)
                           .Include(c=>c.UserCourses)
                           .FirstOrDefault(c => c.CourseId == courseId);
        }
        public List<ShowCourseListItemViewModel> GetPopularCourse()
        {
            return _context.Courses
                           .Include(c => c.OrderDetails)
                           .Where(c=>c.OrderDetails.Any())
                           .OrderByDescending(c => c.OrderDetails.Count)
                           .Take(8)
                           .Select(c => new ShowCourseListItemViewModel()
                           {
                               CourseId = c.CourseId,
                               ImageName = c.CourseImageName,
                               Price = c.CoursePrice,
                               Title = c.CourseTitle,
                               TotalTime = new TimeSpan(c.CourseEpisodes.Sum(e=>e.EpisodeTime.Ticks))
                           })
                           .ToList();
        }
        #endregion

        #region Group
        public List<CourseGroup> GetAllGroup()
        {
            return _context.CourseGroups.Include(g=>g.CourseGroups).ToList();
        }

        public List<SelectListItem> GetGroupForManageCourse()
        {
            return _context.CourseGroups.Where(g => g.ParentId == null)
                .Select(g => new SelectListItem
                {
                    Text = g.GroupTitle,
                    Value = g.GroupId.ToString()
                }).ToList();
        }

        public List<SelectListItem> GetLevels()
        {
            return _context.CourseLevels.Select(s => new SelectListItem()
            {
                Value = s.LevelId.ToString(),
                Text = s.LevelType
            }).ToList();
        }

        public List<SelectListItem> GetStatuses()
        {
            return _context.CourseStatuses.Select(s => new SelectListItem()
            {
                Value = s.StatusId.ToString(),
                Text = s.StatusTitle
            }).ToList();
        }

        public List<SelectListItem> GetSubGroupForManageCourse(int groupId)
        {
            return _context.CourseGroups.Where(g => g.ParentId == groupId)
                .Select(g => new SelectListItem
                {
                    Text = g.GroupTitle,
                    Value = g.GroupId.ToString()
                }).ToList();
        }

        public List<SelectListItem> GetTeachers()
        {
            return _context.UserRoles
                 .Where(r => r.RoleId == 2)
                 .Include(r => r.User)
                 .Select(u => new SelectListItem
                 {
                     Value = u.UserId.ToString(),
                     Text = u.User.UserName
                 }).ToList();
        }

        public int GetSelectedGroupByCourseId(int courseId)
        {
            return _context.Courses.FirstOrDefault(c => c.CourseId == courseId).GroupId;
        }

        #endregion

        #region Episode

        public int AddEpisode(CourseEpisode episode, IFormFile episodeFile)
        {
            episode.EpisodeFileName = episodeFile.FileName;
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CourseFiles", episode.EpisodeFileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                episodeFile.CopyTo(stream);
            }
            _context.CourseEpisodes.Add(episode);
            _context.SaveChanges();
            return episode.CourseId;
        }

        public bool CheckExistFile(string fileName)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CourseFiles", fileName);
            return File.Exists(filePath);
        }

        public List<CourseEpisode> GetListEpisodeCourse(int courseId)
        {
            return _context.CourseEpisodes.Where(c => c.CourseId == courseId).ToList();
        }

        public CourseEpisode GetEpisodeById(int episodeId)
        {
            return _context.CourseEpisodes.Find(episodeId);
        }

        public void EditEpisode(CourseEpisode episode, IFormFile episodeFile)
        {
            if (episodeFile != null)
            {
                string deleteFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CourseFiles", episode.EpisodeFileName);
                File.Delete(deleteFilePath);
                episode.EpisodeFileName = episodeFile.FileName;
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CourseFiles", episode.EpisodeFileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    episodeFile.CopyTo(stream);
                }
            }
            _context.CourseEpisodes.Update(episode);
            _context.SaveChanges();
        }

        #endregion

        #region Comment
        public void AddComment(CourseComment comment)
        {
            _context.CourseComments.Add(comment);
            _context.SaveChanges();
        }


        public Tuple<List<CourseComment>, int> GetCourseComment(int courseId, int pageId = 1)
        {
            int take = 5;
            int skip = (pageId - 1) * take;
            int pageCount = _context.CourseComments.Where(c => !c.IsDelete && c.CourseId == courseId).Count() / take;

            if ((pageCount % 2) != 0)
            {
                pageCount += 1;
            }

            return Tuple.Create(
                _context.CourseComments.Include(c => c.User).Where(c => !c.IsDelete && c.CourseId == courseId).Skip(skip).Take(take)
                    .OrderByDescending(c => c.CreateDate).ToList(), pageCount);
        }

        public void AddGroup(CourseGroup group)
        {
            _context.CourseGroups.Add(group);
            _context.SaveChanges();
        }

        public void UpdateGroup(CourseGroup group)
        {
            _context.CourseGroups.Update(group);
            _context.SaveChanges();
        }

        public CourseGroup GetGroupById(int groupId)
        {
            return _context.CourseGroups.Find(groupId);
        }


        #endregion
    }
}
