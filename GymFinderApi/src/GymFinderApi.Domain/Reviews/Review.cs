namespace GymFinderApi.Domain.Reviews;

public class Review
{
    public Guid Id {  get; set; }
    public Guid GymId { get; set; }
    public Guid UserId {  get; set; }
    public int Stars {  get; set; }
    public string? Text { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
}
