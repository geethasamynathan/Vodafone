using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        // GET: api/<StudentAttendanceController>
        [HttpGet]
        public IEnumerable<StudentAttendanceDetail> Get()
        {
            StudentAttendanceDetail stu1 = new StudentAttendanceDetail();
            StudentAttendanceDetail stu2 = new StudentAttendanceDetail();
            stu1.StudentId = 101;
            stu1.StudentName = "Prema";
            stu1.AttendancePercentage = 78.9;
            stu1.StudentId = 102;
            stu1.StudentName = "Hardik";
            stu1.AttendancePercentage = 98.9;
            List<StudentAttendanceDetail> studentlist = new List<StudentAttendanceDetail>
            {
                stu1,
                stu2
            };
            return studentlist;
        }

        // GET api/<StudentAttendanceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAttendanceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAttendanceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAttendanceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
