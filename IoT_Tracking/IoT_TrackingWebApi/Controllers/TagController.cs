using IoTBussiness.Abstract;
using IoTEntities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoT_TrackingWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        ITagService _tagService;
        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }
        [HttpGet("getTag")]
        public ActionResult GetTag(int tagId)
        {
            var tag = _tagService.GetTag(tagId);
            if (tag.Data!=null)
            {
                return Ok(tag.Data);
            }
            return BadRequest();
        }
        [HttpGet("getAllTag")]
        public ActionResult GetAllTag()
        {
            var tags = _tagService.GetAllTags();
            if (tags.Data.Count>0)
            {
                return Ok(tags.Data);
            }
            return BadRequest();
        }
        [HttpPost("addTag")]
        public ActionResult AddTag(Tag tag)
        {
            var addedTag = _tagService.Add(tag);
            return Ok(addedTag.Message);
        }
        [HttpPost("deleteTag")]
        public ActionResult DeleteTag(int tagId)
        {
            var deleteTag = _tagService.GetTag(tagId);
            _tagService.Delete(deleteTag.Data);
            return Ok();
        }
    }
}
