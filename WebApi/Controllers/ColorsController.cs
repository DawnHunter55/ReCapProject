﻿using Buisness.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _colorservice;
        public ColorsController(IColorService colorService)
        {
            _colorservice = colorService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
           var result = _colorservice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
