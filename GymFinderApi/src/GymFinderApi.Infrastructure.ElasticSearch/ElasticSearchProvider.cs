namespace GymFinderApi.Infrastructure.ElasticSearch
{
    using GymFinderApi.Application.FulltextSeatch;
    using GymFinderApi.Domain.Gyms;

    public class ElasticSearchProvider : ISearchProvider
    {
        public Task IndexGymAsync(Gym gym)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Guid>> SearchAsync(string query, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
