namespace GymFinderApi.Domain.Gym;

public class Gym
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; } 
    public string Description { get; set; } = string.Empty;
    public string CreatedByUserId { get; set; } = string.Empty;
    public string OwnerUserId { get; set; } = string.Empty;
    public Guid CoverPhotoId { get; set; }
    public string Schedule { get; set; } = string.Empty;
    public required string Address { get; set; } 
    public required string City { get; set; }
    public DateTime CreatedAt { get; set; } // дата и время создания сущности
    public bool Status { get; set; } 
}
