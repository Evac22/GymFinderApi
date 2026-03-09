namespace GymFinderApi.Application.FulltextSeatch
{
    using GymFinderApi.Domain.Gyms;

    public interface ISearchProvider
    {
        Task<IEnumerable<Guid>> SearchAsync(string query, CancellationToken cancellationToken);
        Task IndexGymAsync(Gym gym);
    }
}
