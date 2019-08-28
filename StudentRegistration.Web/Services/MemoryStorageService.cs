using StudentRegistration.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentRegistration.Web
{
    public class MemoryStorageService : IStorageService
    {
        public void Create(CourseModel course)
        {
            course.Id = MemoryStorage.Courses.Select(e => e.Id).Max() + 1;
            MemoryStorage.Courses.Add(course);
        }
        public void Update(CourseModel course)
        {
          var item=  Get( course.Id);
            item.Period = course.Period;
            item.Name = course.Name;
            
        }
        public void Delete(int id)
        {
            var itemToDelete = MemoryStorage.Courses.First(e => e.Id == id);
            MemoryStorage.Courses.Remove(itemToDelete);
        }
        public CourseModel Get(int id)
        {
            var result = MemoryStorage.Courses.First(e => e.Id == id);
            return result;
        }
        public List<CourseModel> GetAll()
        {
            return MemoryStorage.Courses;
        }
    }

    public class MemoryStorage
    {
        public static List<CourseModel> Courses { get; set; } = new List<CourseModel>();
    }
}
