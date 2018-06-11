namespace Mpc.MyRace.Application.Services.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Mpc.MyRace.Application.Dto;

    public interface IEventService
    {
        Task<Event> CreateAsync(Event @event);

        Task<IEnumerable<Event>> GetAllAsync(int? page, int? pageSize);

        Task<Event> GetAsync(int id);
    }
}
