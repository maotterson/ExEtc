using ExEtc.Mobile.Data;

namespace ExEtc.Mobile.Services;
public class NewWorkoutService : INewWorkoutService
{
    private List<ExerciseDto> exercises = new List<ExerciseDto>();

    public List<ExerciseDto> GetExercises()
    {
        return exercises;
    }

    public void NewExercise()
    {
        var newExercise = new ExerciseDto();
        exercises.Add(newExercise);
    }
}
