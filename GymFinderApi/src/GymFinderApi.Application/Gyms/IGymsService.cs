namespace GymFinderApi.Application.Gyms
{
    using GymFinderApi.Contracts.GymDto;

    public interface IGymsService
    {
        Task<Guid> Create(CreateGymDTO gymDTO, CancellationToken cancellationToken);
    }
}
