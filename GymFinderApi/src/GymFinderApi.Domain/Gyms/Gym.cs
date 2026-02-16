namespace GymFinderApi.Domain.Gyms;

public class Gym
{
    public Gym(
        Guid id,
        string name,
        string description,
        string city,
        string address,
        string schedule)
    {
        this.Id = id;
        this.Name = name;
        this.Description = description;
        this.City = city;
        this.Address = address;
    }

    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string Schedule { get; set; } = string.Empty;

    public Guid CreatedByUserId { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public DateTimeOffset? UpdatedAt { get; set; }

    public bool IsHidden { get; set; }
}
