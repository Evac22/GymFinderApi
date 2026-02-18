namespace GymFinderApi.Application.Gyms
{
    using FluentValidation;
    using GymFinderApi.Contracts.GymDto;
    using GymFinderApi.Domain.Gyms;
    using Microsoft.Extensions.Logging;

    public class GymsService : IGymsService
    {
        private readonly IGymsRepository _gymsRepository;
        private readonly ILogger<GymsService> _logger;
        private readonly IValidator<CreateGymDTO> _validator;

        public GymsService(
            IGymsRepository gymsRepository,
            ILogger<GymsService> logger,
            IValidator<CreateGymDTO> validator)
        {
            this._gymsRepository = gymsRepository;
            this._logger = logger;
            this._validator = validator;
        }

        public async Task<Guid> Create(CreateGymDTO gymDTO, CancellationToken cancellationToken)
        {
            // Logic to create a gym
            // проверка валидации данных
            var validationResult = await _validator.ValidateAsync(gymDTO, cancellationToken);
            if (!validationResult.IsValid)
            {
                // логирование ошибок валидации
                _logger.LogWarning("Validation failed for CreateGymDTO: {Errors}", validationResult.Errors);
                throw new ValidationException(validationResult.Errors);
            }

            // создание сущности Gym
            var gymId = Guid.NewGuid();

            var gym = new Gym(
               gymId,
               gymDTO.Name,
               gymDTO.Description,
               gymDTO.City,
               gymDTO.Address,
               gymDTO.Schedule);

            // сохранение в базу данных
            await _gymsRepository.AddAsync(gym, cancellationToken);

            // логирование операции
            _logger.LogInformation("Gym created with ID: {GymId}", gymId);
            return gymId;
        }

        ////public async Task<IActionResult> Update(Guid gymId,UpdateGymDto request, CancellationToken cancellationToken)
        ////{

        ////}

        ////public async Task<IActionResult> Delete(Guid gymId, CancellationToken cancellationToken)
        ////{

        ////}
    }
}
