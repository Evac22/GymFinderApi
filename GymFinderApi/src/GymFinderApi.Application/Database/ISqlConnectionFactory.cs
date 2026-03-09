namespace GymFinderApi.Application.Database
{
    using System.Data;

    public interface ISqlConnectionFactory
    {
        IDbConnection Create();
    }
}
