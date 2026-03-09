namespace GymFinderApi.Infrastructure.Postgres
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using GymFinderApi.Domain.Gyms;
    using Microsoft.EntityFrameworkCore;

    public class GymDbContext : DbContext
    {
        public DbSet<Gym> Gyms { get; set; }
    }
}
