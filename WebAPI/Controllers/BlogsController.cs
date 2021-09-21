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
    public class BlogsController : ControllerBase
    {
        IBlogService _blogService;
        public BlogsController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _blogService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _blogService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Blog blog)
        {
            var result = _blogService.Add(blog);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        

     

    }
}
