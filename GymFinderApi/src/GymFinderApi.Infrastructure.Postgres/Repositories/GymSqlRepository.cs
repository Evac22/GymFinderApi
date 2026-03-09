namespace GymFinderApi.Infrastructure.Postgres.Repositories
{
    using Dapper;
    using GymFinderApi.Application.Database;
    using GymFinderApi.Application.Gyms;
    using GymFinderApi.Domain.Gyms;

    public class GymSqlRepository : IGymsRepository
    {
        private ISqlConnectionFactory _sqlConnectionFactory;

        public GymSqlRepository(Application.Database.ISqlConnectionFactory sqlConnectionFactory)
        {
            this._sqlConnectionFactory = sqlConnectionFactory;
        }

        public async Task<Guid> AddAsync(Gym gym, CancellationToken cancellationToken)
        {
          const string sql = @"
            INSERT INTO gyms (id, name, description, city, address, schedule)
            VALUES (@Id, @Name, @Description, @City, @Address, @Schedule)";

          using var connectoin = _sqlConnectionFactory.Create();
          await connectoin.ExecuteAsync(sql, new
            {
                Id = gym.Id,
                Name = gym.Name,
                Description = gym.Description,
                City = gym.City,
                Address = gym.Address,
                Schedule = gym.Schedule,
            });
          return gym.Id;
        }

        public Task<Guid> DeleteAsync(Guid gymId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Gym?> GetByIdAsync(Guid gymId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> SaveAsync(Gym gym, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
