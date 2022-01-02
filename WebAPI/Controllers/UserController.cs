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
    public class UserController : ControllerBase
    {
        [HttpPost("add")]
        public IActionResult UserAdd()
        {
            return Ok("Kullanıcı ekle");
        }

        [HttpPut("update")]
        public IActionResult UserUpdate()
        {
            return Ok("Kullanıcı güncelle");
        }

        [HttpDelete("delete")]
        public IActionResult UserDelete()
        {
            return Ok("Kullanıcı sil");
        }

        [HttpGet("getall")]
        public IActionResult GetAllUser()
        {
            return Ok("tüm kullanıcıları getir");
        }


        [HttpGet("getbyid")]
        public IActionResult GetUserById()
        {
            return Ok("id'li kullanıcı");
        }


    }
}
