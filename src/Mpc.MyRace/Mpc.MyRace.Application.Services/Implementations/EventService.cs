namespace Mpc.MyRace.Application.Services.Implementations
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Mpc.MyRace.Application.Dto;
    using Mpc.MyRace.Application.Services.Interfaces;

    internal class EventService : IEventService
    {
        public Task<Event> CreateAsync(Event @event)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Event>> GetAllAsync(int? page, int? pageSize)
        {
            throw new System.NotImplementedException();
        }

        public Task<Event> GetAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
