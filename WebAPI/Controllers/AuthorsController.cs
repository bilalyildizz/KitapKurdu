using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {

        IAuthorService _authorService;
        
        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

          /// <summary>
          /// Get All Authors
          /// </summary>
          /// <returns></returns>
        [HttpGet("getall")]
        public ActionResult GetAll()
        {

            var result = _authorService.GetAll();
            if (result == null)
            {
                return BadRequest("Yazar bulunamadı");
            }

            return Ok(result);

        }

        /// <summary>
        /// Get Authors By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getbyid")]
        public ActionResult GetById(int id)
        {

            var result = _authorService.GetById(id);
            if (result == null)
            {
                return BadRequest("Yazar bulunamadı");
            }

            return Ok(result);

        }



    }
}
