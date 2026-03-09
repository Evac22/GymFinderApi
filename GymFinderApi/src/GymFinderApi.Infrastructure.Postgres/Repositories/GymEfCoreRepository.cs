namespace GymFinderApi.Infrastructure.Postgres.Repositories
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using GymFinderApi.Application.Gyms;
    using GymFinderApi.Domain.Gyms;
    using Microsoft.EntityFrameworkCore;

    public class GymEfCoreRepository : IGymsRepository
    {
        private readonly GymDbContext _dbContext;

        public GymEfCoreRepository(GymDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> AddAsync(Gym gym, CancellationToken cancellationToken)
        {
           await _dbContext.Gyms.AddAsync(gym, cancellationToken);
           await _dbContext.SaveChangesAsync(cancellationToken);
           return gym.Id;
        }

        public Task<Guid> DeleteAsync(Guid gymId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Gym?> GetByIdAsync(Guid gymId, CancellationToken cancellationToken)
        {
            var gym = await _dbContext.Gyms
                .FirstOrDefaultAsync(g => g.Id == gymId, cancellationToken);
            return gym;
        }

        public Task<Guid> SaveAsync(Gym gym, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
