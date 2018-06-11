namespace Mpc.MyRace.Application.Dto
{
    using System;
    using System.Collections.Generic;

    public class Event
    {
        public string Description { get; set; }

        public DateTime EndDate { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Race> Races { get; set; }

        public DateTime StartDate { get; set; }
    }
}
