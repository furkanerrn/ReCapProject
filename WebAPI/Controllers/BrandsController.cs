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
    public class BrandsController : ControllerBase
    {
        IBrandService _brandservice;

        public BrandsController(IBrandService brandservice)
        {
            _brandservice = brandservice;
        }
        [HttpGet("getall")]
        public  IActionResult GetAll()
        {
           
            var res = _brandservice.GetAll();
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }

        [HttpGet("brandıd")]
        public IActionResult GetById(int id)
        {
            var res = _brandservice.GetByBrandId(id);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }


        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            var res = _brandservice.Add(brand);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res.Message);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Brand brand)
        {
            var res = _brandservice.Delete(brand);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }

        [HttpPut("update")]
        public IActionResult Update(Brand brand)
        {
            var res = _brandservice.Update(brand);
            if (res.Success)
            {
                return Ok(res);

            }
            return BadRequest(res);
        }


    }
}
