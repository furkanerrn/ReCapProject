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
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
           
            var res = _userService.GetAll();
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res.Data);
        }


        [HttpPut("update")]
        public IActionResult Update(Users user)
        {
            var res = _userService.Update(user);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);


        }
        [HttpGet("getuserbyıd")]
        public IActionResult GetUserById(int id)
        {
            var res = _userService.GetUserById(id);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }


    }
}
