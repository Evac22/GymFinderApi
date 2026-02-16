namespace GymFinderApi.Domain.Photos;

public class GymPhoto
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid GymId { get; set; }

    public Guid UserId { get; set; }

    public string Url { get; set; } = string.Empty;

    public DateTimeOffset CreatedAt { get; set; }
}
