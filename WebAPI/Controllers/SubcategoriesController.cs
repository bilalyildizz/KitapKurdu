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
    public class SubcategoriesController : ControllerBase
    {
        ISubcategoryService _subcategoryService;

        public SubcategoriesController(ISubcategoryService subcategoryService)
        {
            _subcategoryService = subcategoryService;

        }

        /// <summary>
        /// Get All Subcategories
        /// </summary>
        /// <returns></returns>

        [HttpGet("getall")]
        public ActionResult GetAll()
        {

            var result = _subcategoryService.GetAll();
            if (result == null)
            {
                return BadRequest("Alt kategori bulunamadı");
            }

            return Ok(result);

        }

        /// <summary>
        /// Get Subcategory By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        [HttpGet("getbyid")]
        public ActionResult GetById(int id)
        {

            var result = _subcategoryService.GetById(id);
            if (result == null)
            {
                return BadRequest("Alt kategori bulunamadı");
            }

            return Ok(result);

        }


        /// <summary>
        /// Get Subcategory By Category Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("getbycategoryid")]
        public ActionResult GetByCategoryId(int id)
        {

            var result = _subcategoryService.GetByCategoryId(id);
            if (result == null)
            {
                return BadRequest("Alt kategori bulunamadı");
            }

            return Ok(result);

        }


    }
}
