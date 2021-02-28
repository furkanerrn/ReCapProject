using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
           
            var res = _customerService.GetAll();
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res.Data);

        }

        [HttpGet("getbyıd")] 
        public IActionResult GetById(int customerıd)
        {
            var res = _customerService.GetCustomerById(customerıd);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }

        [HttpPost("add")]
        public IActionResult Add(Customers customers)
        {
            var res = _customerService.Add(customers);
            if (res.Success)
            {
                return Ok(res);

            }
            return BadRequest(res);
        }

        [HttpPut("update")]
        public IActionResult Update(Customers customers)
        {
            var res = _customerService.Update(customers);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }
    }
}
