using Microsoft.EntityFrameworkCore;
using StudentRegistration.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentRegistration.Web.Services
{
    public class StudentsService
    {
        private readonly RegistrationContext _context;

        public StudentsService(RegistrationContext context, CountryService e)
        {
            this._context = context;
        }

        public void Create(Student student)
        {
            student.DateOfBirth = DateTime.Now;
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public IEnumerable<Student> GetPage(int pageNo, int pageSize, string name)
        {
            var page = pageNo - 1;
            var skip = page * pageSize;

            IQueryable<Student> query = _context.Students
                 .Where(e => string.IsNullOrEmpty(name) 
                 || e.Name.ToLower().Contains(name.ToLower()))
                 .AsNoTracking();

            if (pageNo > 0)
            {
                query = query
                    .Skip(skip)
                    .Take(pageSize);
            }
            var results = query.ToArray();

            return results;
        }

        public Student Get(int id)
        {
            return _context.Students.Find(id);
        }

        public void Update(int id, Student student)
        {
            student.Id = id;
            var entry = _context.Entry<Student>(student);

            entry.State = EntityState.Modified;

            foreach (var prop in entry.Properties)
            {
                prop.IsModified = false;
            }

            entry.Property(e => e.Name).IsModified = true;
            entry.Property(e => e.NationalId).IsModified = true;

            //var entity = _context.Students.Find(id);
            //entity.Name = student.Name;
            //entity.NationalId = student.NationalId;

            _context.SaveChanges();
        }

        internal void Delete(int id)
        {
            var student = new Student { Id = id };
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        internal void Deactivate(int id)
        {
            
        }
    }
}
