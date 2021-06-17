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
    public class BooksController : ControllerBase
    {
        IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }


        /// <summary>
        /// Get All Books
        /// </summary>
        /// <returns></returns>

        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            var result = _bookService.GetAll();
            if (result == null)
            {
                return BadRequest("Kitap Bulunamadı");
            }

            return Ok(result);

        }

        /// <summary>
        /// Get Book By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("getbyid")]
        public ActionResult GetBookById(int id)
        {
            var result = _bookService.GetBookById(id);
            if (result == null)
            {
                return BadRequest("Kitap Bulunamadı");
            }

            return Ok(result);

        }

        /// <summary>
        /// Get Book By Subcategory Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("getbysubcategoryid")]
        public ActionResult GetBookBySubcategoryId(int id)
        {
            var result = _bookService.GetBookBySubcategoryId(id);
            if (result == null)
            {
                return BadRequest("Kitap Bulunamadı");
            }

            return Ok(result);

        }

        /// <summary>
        /// Get Book By Publisher Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // getbookbypublisherid/?id=1    
        [HttpGet("getbypublisherid")]
        public ActionResult GetBookByPublisherId(int id)
        {
            var result = _bookService.GetBookByPublisherId(id);
            if (result == null)
            {
                return BadRequest("Kitap Bulunamadı");
            }

            return Ok(result);

        }

        /// <summary>
        /// Get Book By Author Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getbyauthorid")]
        public ActionResult GetBookByAuthorId(int id)
        {
            var result = _bookService.GetBookByAuthorId(id);
            if (result == null)
            {
                return BadRequest("Kitap Bulunamadı");
            }

            return Ok(result);

        }






    }
}
