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
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
           
            var res = _colorService.GetAll();
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res.Data);
        }

        [HttpPost("add")]
        public IActionResult Add(Color color)
        {
            var res = _colorService.Add(color);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }

    }
}
