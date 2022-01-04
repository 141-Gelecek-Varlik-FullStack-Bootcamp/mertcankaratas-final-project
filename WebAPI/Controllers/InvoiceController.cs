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
    public class InvoiceController : ControllerBase
    {
        [HttpPost("add")]
        public IActionResult InvoiceAdd()
        {
            return Ok("Invoice ekle");
        }

        [HttpPut("update")]
        public IActionResult InvoiceUpdate()
        {
            return Ok("Invoice güncelle");
        }

        [HttpDelete("delete")]
        public IActionResult InvoiceDelete()
        {
            return Ok("Invoice sil");
        }

        [HttpGet("getall")]
        public IActionResult GetAllInvoice()
        {
            return Ok("tüm Invoice'ları getir");
        }


        [HttpGet("getbyid")]
        public IActionResult GetApartmentById()
        {
            return Ok("id'li Invoice");
        }


      
    }
}
