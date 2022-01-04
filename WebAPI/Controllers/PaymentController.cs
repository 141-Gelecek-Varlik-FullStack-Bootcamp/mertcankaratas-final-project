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
    public class PaymentController : ControllerBase
    {
        [HttpPost("add")]
        public IActionResult PaymentAdd()
        {
            return Ok("Payment ekle");
        }

        [HttpPut("update")]
        public IActionResult PaymentUpdate()
        {
            return Ok("Payment güncelle");
        }

        [HttpDelete("delete")]
        public IActionResult PaymentDelete()
        {
            return Ok("Payment sil");
        }

        [HttpGet("getall")]
        public IActionResult GetAllPayment()
        {
            return Ok("tüm Payment'ları getir");
        }


        [HttpGet("getbyid")]
        public IActionResult GetPaymentById()
        {
            return Ok("id'li Payment");
        }

        [HttpGet("getbybillingdate")]
        public IActionResult GetPaymentByBillingDate()
        {
            return Ok("billing date Payment");
        }

        [HttpGet("getbyduedate")]
        public IActionResult GetPaymentByDueDate()
        {
            return Ok("due date Payment");
        }
        
        [HttpGet("getbypastduedate")]
        public IActionResult GetPaymentByPastDueDate()
        {
            return Ok("past due date Payment");
        }


        [HttpGet("getbysuccesspayment")]
        public IActionResult GetPaymentBySuccessPayment()
        {
            return Ok("Success Payment");
        }



    }
}
