namespace Mpc.MyRace.Api.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Mpc.MyRace.Application.Dto;
    using Mpc.MyRace.Application.Services.Interfaces;

    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private IEventService _eventService;

        public EventsController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Event>), 200)]
        public async Task<ActionResult<IEnumerable<Event>>> GetAllAsync(int? page, int? pageSize)
        {
            var events = await _eventService.GetAllAsync(page, pageSize).ConfigureAwait(false);

            return Ok(events);
        }

        [HttpGet(Name = "GetEvent")]
        [Route("{id:int}"]
        [ProducesResponseType(typeof(IEnumerable<Event>), 200)]
        public async Task<ActionResult<IEnumerable<Event>>> GetAsync(int id)
        {
            var @event = await _eventService.GetAsync(id).ConfigureAwait(false);

            return Ok(@event);
        }

        [HttpPost]
        [ProducesResponseType(typeof(IEnumerable<Event>), 201)]
        public async Task<ActionResult<IEnumerable<Event>>> PostAsync(Event @event)
        {
            var newEvent = await _eventService.CreateAsync(@event).ConfigureAwait(false);

            return CreatedAtRoute("GetEvent", new { id = newEvent.Id }, newEvent);
        }
    }
}
