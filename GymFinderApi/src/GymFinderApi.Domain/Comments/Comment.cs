namespace GymFinderApi.Domain.Comments;

public class Comment
{
    public Guid Id { get; set; }
    public Guid GymId { get; set; }
    public Guid UserId { get; set; }
    public string Text { get; set; } = string.Empty;
    public Guid? ParentCommentId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
}
