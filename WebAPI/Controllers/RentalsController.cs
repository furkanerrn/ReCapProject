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
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
           
            var res = _rentalService.GetAll();
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }

        [HttpGet("getrentalıd")]
        public IActionResult GetRentalId(int id)
        {
            var res= _rentalService.GetRentalDetails(id);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }

        [HttpPost("add")]
        public IActionResult Add(Rentals rental)
        {
            var res = _rentalService.Add(rental);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }

        
       
        [HttpDelete("delete")]
        public IActionResult Delete(Rentals rental)
        {
            var res = _rentalService.Delete(rental);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }


        [HttpPut("update")]
        public IActionResult Update(Rentals rental)
        {
            var res = _rentalService.Update(rental);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }
    }
}
