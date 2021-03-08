using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Training.Data.Context;
using Training.Data.Models;
using Training.Data.Repository;

namespace Training.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        public IRepository<Doctor> contextDoctors { get; private set; }
        public DoctorsController(
            IRepository<Doctor> contextDoctors
            )
        {
            this.contextDoctors = contextDoctors;
        }

        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return contextDoctors.All;
        }

        [HttpGet("{id}")]
        public ActionResult<Doctor> Get( int id)
        {
            return contextDoctors.FindById(id);
        }

        [HttpPost]
        public void Post([FromQuery] Doctor value)
        {
            contextDoctors.Update(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Doctor value)
        {
            contextDoctors.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var entity = contextDoctors.FindById(id);
            contextDoctors.Delete(entity);
        }
    }
}
