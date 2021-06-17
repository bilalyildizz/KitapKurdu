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
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// Get All Categories
        /// </summary>
        /// <returns></returns>

        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            if (result == null)
            {
                return BadRequest("Kategori Bulunamadı");
            }

            return Ok(result);
        }


        /// <summary>
        /// Get Category By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("getbyid")]
        public ActionResult GetById(int id)
        {
            var result = _categoryService.GetById(id);
            if (result == null)
            {
                return BadRequest("Kategori Bulunamadı");
            }

            return Ok(result);
        }
    }
}
