﻿using UserMasterAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserMasterAPI.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private Learn_DBContext context;
        public CustomerController(Learn_DBContext learn_DB) 
        {
            context = learn_DB;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<TblCustomer> Get()
        {
            return context.TblCustomer.ToList();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
