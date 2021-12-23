using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        // GET: api/<StudentAdmissionController>
        [HttpGet]
        public IEnumerable<StudentAdmissionDetail> Get()
        {
            StudentAdmissionDetail stu1 = new StudentAdmissionDetail();
            StudentAdmissionDetail stu2 = new StudentAdmissionDetail();
            stu1.StudentId = 11;
            stu1.StudentName = "Peter";
            stu1.StudentClass = "10";
           
            stu1.StudentId = 12;
            stu1.StudentName = "John";
            stu1.StudentClass = "9";
           
            List<StudentAdmissionDetail> studentadmissionlist = new List<StudentAdmissionDetail>();
            studentadmissionlist.Add(stu1);
            studentadmissionlist.Add(stu2);
            return studentadmissionlist;
        }

        // GET api/<StudentAdmissionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAdmissionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAdmissionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAdmissionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
