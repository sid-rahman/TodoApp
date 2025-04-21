using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Business.DTOs;
using TodoApp.Business.Services;
using TodoApp.Data.Entities;


namespace TodoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventService eventService;

        public EventsController(IEventService eventService)
        {
            this.eventService = eventService;
        }

        [HttpGet]
        public IActionResult GetAllEvents()
        {
            var events = eventService.GetAllEvents();
            return Ok(events);
        }

        [HttpGet("{id}")]
        public IActionResult GetEvent(int id)
        {
            var evt = eventService.GetEvent(id);
            return evt != null ? Ok(evt) : NotFound();
        }

        [HttpPost]
        public IActionResult CreateNewEvent(EventDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var newEvent = eventService.CreateEvent(dto);
            return Ok(newEvent);

        }

        [HttpPut("{id}")]
        public IActionResult EditEvent(EventDTO dto, int id)
        {
            var updatedEvent = eventService.UpdateEvent(dto, id);
            return Ok(updatedEvent);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEvent(int id)
        {
            eventService.DeleteEvent(id);
            return Ok();
        }
    }
}
