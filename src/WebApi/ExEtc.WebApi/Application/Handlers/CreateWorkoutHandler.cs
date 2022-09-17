using ExEtc.Contracts.Local.v1.Workouts.CreateWorkout;
using MediatR;

namespace ExEtc.WebApi.Application.Handlers;
public class CreateWorkoutHandler : IRequestHandler<CreateWorkoutCommand, CreateWorkoutResponse>
{
    public Task<CreateWorkoutResponse> Handle(CreateWorkoutCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
