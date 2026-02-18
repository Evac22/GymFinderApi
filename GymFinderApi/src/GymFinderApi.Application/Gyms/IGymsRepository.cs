namespace GymFinderApi.Application.Gyms
{
    using GymFinderApi.Domain.Gyms;

    public interface IGymsRepository
    {
        Task<Guid> AddAsync(Gym gym, CancellationToken cancellationToken);

        Task<Guid> SaveAsync(Gym gym, CancellationToken cancellationToken);

        Task<Guid> DeleteAsync(Guid gymId, CancellationToken cancellationToken);

        Task<Gym> GetByIdAsync(Guid gymId, CancellationToken cancellationToken);
    }
}
