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
    public class PublishersController : ControllerBase
    {
        IPublisherService _publisherService;

        public PublishersController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }

        /// <summary>
        /// Get All Publishers
        /// </summary>
        /// <returns></returns>

        [HttpGet("getall")]
        public ActionResult GetAll()
        {

            var result = _publisherService.GetAll();
            if (result == null)
            {
                return BadRequest("Yayınevi bulunamadı");
            }

            return Ok(result);

        }

        /// <summary>
        /// Get Publisher By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("getbyid")]
        public ActionResult GetById(int id)
        {

            var result = _publisherService.GetById(id);
            if (result == null)
            {
                return BadRequest("Yayınevi bulunamadı");
            }

            return Ok(result);

        }

    }
}
