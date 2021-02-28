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
    public class CarsController : ControllerBase
    {
        ICarService _carService;  // Dependency injection yaptık.

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

       
        
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var res = _carService.GetAll();
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }

        [HttpGet("getbyıd")]
        public IActionResult GetById(int id)
        {
            var res=_carService.GetCarById(id);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);

        }

        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var res = _carService.Add(car);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Car car)
        {
            var res = _carService.Delete(car);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }


        [HttpPut("update")]
        public IActionResult Update(Car car)
        {
            var res = _carService.Update(car);
            if (res.Success)
            {
                return Ok(res);

            }
            return BadRequest(res);
        }

        [HttpGet("getcardetaildto")]
        public IActionResult GetCarDetailsDto()
        {
            var res = _carService.GetProductDetails();
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }



    }
}
