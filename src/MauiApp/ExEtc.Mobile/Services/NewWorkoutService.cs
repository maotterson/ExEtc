using ExEtc.Mobile.Data;

namespace ExEtc.Mobile.Services;
public class NewWorkoutService : INewWorkoutService
{
    public List<ExerciseDto> Exercises { get; set; } = new List<ExerciseDto>();

    public void NewExercise()
    {
        throw new NotImplementedException();
    }
}
