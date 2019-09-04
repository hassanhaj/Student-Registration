using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Web.Entities;
using StudentRegistration.Web.Services;

namespace StudentRegistration.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsApiController : ControllerBase
    {
        private readonly StudentsService _service;

        public StudentsApiController(StudentsService service)
        {
            this._service = service;
        }

        // GET: api/StudentsApi
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _service.GetPage(1, 5, null);
        }

        // GET: api/StudentsApi/5
        [HttpGet("{id}", Name = "Get")]
        public Student Get(int id)
        {
            return _service.Get(id);
        }

        // POST: api/StudentsApi
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            _service.Create(student);
        }

        // PUT: api/StudentsApi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student student)
        {
            _service.Update(id, student);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
