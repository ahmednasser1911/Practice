using BreackFast.Contracts.BreakFast;
using BreakFast.API.Model;
using BreakFast.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BreakFast.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreakFastController : ControllerBase
    {

        private readonly IBreakFastService breakFastService;

        public BreakFastController(IBreakFastService breakFastService)
        {
            this.breakFastService = breakFastService;
        }

        [HttpPost]
        public IActionResult CreateBreakFast(CreateBreakFastRequest request)
        {
            var breakFast = new BreakFastModel(Guid.NewGuid() , request.Name, request.Description , request.StartDate , request.EndDate,request.Savory,request.Sweet);

            // save db
            breakFastService.CreateBreakFast(breakFast);

            var response = new BreakFastResponse
            {
                Id= breakFast.id,
                Name = breakFast.Name,
                Description = breakFast.Description,
                StartDate = breakFast.StartDate,
                EndDate = breakFast.EndDate,
                Savory = breakFast.Savory,
                Sweet = breakFast.Sweet
            };

            return CreatedAtAction(nameof(CreateBreakFast) , new {id = breakFast.id} , response);
        }

        [HttpGet]
        public IActionResult GetBreakFasts()
        {
            var breakFasts = breakFastService.GetBreakFastList();
            return Ok(breakFasts);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetBreakFast(Guid id)
        {
            var breakFast = breakFastService.GetBreakFast(id);
            var response = new BreakFastResponse
            {
                Id = id,
                Name = breakFast.Name,
                Description = breakFast.Description,
                EndDate = breakFast.EndDate,
                Savory = breakFast.Savory,
                StartDate = breakFast.StartDate,
                Sweet = breakFast.Sweet,
                LastModefiedDate = DateTime.Now,
            };
            return Ok(response);
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpsertBreakFast(Guid id , UpsertBreakFastRequest request)
        {
            var breakFast = new BreakFastModel(id: id,name:request.Name ,description: request.Description,startDate: request.StartDate,endDate: request.EndDate, savory: request.Savory,sweet: request.Sweet);
            breakFastService.UpsertBreakFast(breakFast);

            // if new 201
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteBreakFast(Guid id)
        {
            breakFastService.RemoveBreakFast(id);
            return NoContent();
        }
    }

}
