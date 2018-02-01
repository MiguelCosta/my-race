namespace Mpc.MyRace.Domain.Model
{
    using System;
    using Mpc.MyRace.Domain.Model.Enums;

    public class Racer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Email { get; set; }

        public Gender Gender { get; set; }
    }
}
