namespace GymFinderApi.Application
{
    using GymFinderApi.Contracts.GymDto;
    using GymFinderApi.Domain.Gyms;

    public class GymsService
    {
       
        public async Task Create(CreateGymDTO gymDTO, CancellationToken cancellationToken)
        {
            // Logic to create a gym
            // проверка валидации данных
            // создание сущности Gym
            var gymId = Guid.NewGuid();
            var gym = new Gym
            {
               Id = gymId,
                Name = gymDTO.Name,
                Description = gymDTO.Description,
                City = gymDTO.City,
                Address = gymDTO.Address,
                Schedule = gymDTO.Schedule
            };
            // сохранение в базу данных
            // логирование операции

        }






        public async Task<IActionResult> Update(Guid gymId,UpdateGymDto request, CancellationToken cancellationToken)
        {
            
        }

       
        public async Task<IActionResult> Delete(Guid gymId, CancellationToken cancellationToken)
        {
           
        }
    }
}
