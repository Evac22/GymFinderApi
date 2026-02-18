namespace GymFinderApi.Presenters.Controllers
{
    using GymFinderApi.Contracts.CommentDto;
    using Microsoft.AspNetCore.Mvc;

    public class CommentController : ControllerBase
    {
            [HttpPost]
            public async Task<IActionResult> Create([FromBody] CreateCommentDto request)
            {
                return Ok("Comment created");
            }

            [HttpGet]
            public async Task<IActionResult> Get()
            {
                return Ok("All comments");
            }
    }
}
