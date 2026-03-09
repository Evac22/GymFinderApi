namespace GymFinderApi.Infrastructure.Postgres.Seeders
{
    using GymFinderApi.Infrastructure.Postgres;

    public class GymSeeder : ISeeder
    {
        private readonly GymDbContext _dbContext;

        public GymSeeder(GymDbContext dbContext)
        {
           _dbContext = dbContext;
        }

        public Task SeedAsync()
        {
            throw new NotImplementedException();
        }
    }
}
