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
    public class ApartmentController : ControllerBase
    {
        [HttpPost("add")]
        public IActionResult ApartmentAdd()
        {
            return Ok("Apartment ekle");
        }

        [HttpPut("update")]
        public IActionResult ApartmentUpdate()
        {
            return Ok("Apartment güncelle");
        }

        [HttpDelete("delete")]
        public IActionResult ApartmentDelete()
        {
            return Ok("Apartment sil");
        }

        [HttpGet("getall")]
        public IActionResult GetAllApartment()
        {
            return Ok("tüm Apartment'ları getir");
        }


        [HttpGet("getbyid")]
        public IActionResult GetApartmentById()
        {
            return Ok("id'li Apartment");
        }

        [HttpGet("getbyblank")]
        public IActionResult GetApartmentByBlank()
        {
            return Ok(" blank Apartment getir");
        }

        [HttpGet("getbyblankactive")]
        public IActionResult GetApartmentByBlankActive()
        {
            return Ok(" blank and active Apartment getir");
        }

    }
}
