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
    public class DuesController : ControllerBase
    {
        [HttpPost("add")]
        public IActionResult DuesAdd()
        {
            return Ok("Dues ekle");
        }

        [HttpPut("update")]
        public IActionResult DuesUpdate()
        {
            return Ok("Dues güncelle");
        }

        [HttpDelete("delete")]
        public IActionResult DuesDelete()
        {
            return Ok("Dues sil");
        }

        [HttpGet("getall")]
        public IActionResult GetAllDues()
        {
            return Ok("tüm Dues'ları getir");
        }


        [HttpGet("getbyid")]
        public IActionResult GetDuesById()
        {
            return Ok("id'li Dues");
        }
    }
}
