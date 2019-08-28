using System.Collections.Generic;
using StudentRegistration.Web.Models;

namespace StudentRegistration.Web
{
    public interface IStorageService
    {
        void Create(CourseModel course);
        void Delete(int id);
        CourseModel Get(int id);
        List<CourseModel> GetAll();
        void Update(CourseModel course);
    }
}