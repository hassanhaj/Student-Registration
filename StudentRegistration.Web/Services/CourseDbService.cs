using StudentRegistration.Web.Entities;
using StudentRegistration.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentRegistration.Web
{
    public class CourseDbService : IStorageService
    {
        private readonly RegistrationContext _context;

        public CourseDbService(RegistrationContext context)
        {
            this._context = context;
        }

        public void Create(CourseModel course)
        {
            var courseEntity = new Course
            {
                Id = course.Id,
                Name = course.Name,
                Period = course.Period
            };

            _context.Courses.Add(courseEntity);
            _context.SaveChanges();
        }
        public void Update(CourseModel course)
        {

            throw new System.Exception();

        }
        public void Delete(int id)
        {
            throw new System.Exception();
        }
        public CourseModel Get(int id)
        {

            throw new System.Exception();
        }
        public List<CourseModel> GetAll()
        {
            var result = _context.Courses
                .Select(e => new CourseModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Period = e.Period
                })
                .ToList();

            return result;
        }
    }

}
