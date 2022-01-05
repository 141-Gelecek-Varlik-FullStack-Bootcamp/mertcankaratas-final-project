using Business.Abstract;
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
    public class ApartmentController : ControllerBase
    {
        private readonly IApartmentService _apartmentService;

        public ApartmentController(IApartmentService apartmentService)
        {
            _apartmentService = apartmentService;
        }

        [HttpPost("add")]
        public IActionResult ApartmentAdd(Apartment apartment)
        {
            var result = _apartmentService.Add(apartment);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult ApartmentUpdate(Apartment apartment)
        {
            var result = _apartmentService.Update(apartment);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult ApartmentDelete(Apartment apartment)
        {
            var result = _apartmentService.Update(apartment);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAllApartment()
        {
            var result = _apartmentService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpGet("getbyid")]
        public IActionResult GetApartmentById(int id)
        {
            var result = _apartmentService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
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
