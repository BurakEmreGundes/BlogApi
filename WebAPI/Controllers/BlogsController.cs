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
        
        [HttpGet]
        public IActionResult Get()
        {
            var result = _blogService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            
            return BadRequest(result);
        }

        [HttpPost]
        public IActionResult Post(Blog blog)
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
