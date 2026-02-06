
namespace GymFinderApi.Domain.Comment;

public class CommentPhoto
{
    public Guid Id { get; set; }
    public Guid CommentId { get; set; }
    public string Url { get; set; } = string.Empty;
    public DateTimeOffset CreatedAt { get; set; }
}