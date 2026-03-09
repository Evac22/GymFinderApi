namespace GymFinderApi.Infrastructure.S3
{
    using GymFinderApi.Application.FilesStorage;

    public class S3Provider : IFilesProvider
    {
        public Task<string> UploadAsync(Stream stream, string key, string bucket)
        {
            throw new NotImplementedException();
        }
    }
}
