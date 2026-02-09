namespace GymFinderApi.Contracts
{
    public record CreateGymDTO(string Name, string Description, string City,
    string Address, string Schedule);
}
