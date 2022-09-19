using ExEtc.Mobile.Data;

namespace ExEtc.Mobile.Services;
public interface INewWorkoutService
{
    void NewExercise();
    List<ExerciseDto> GetExercises();
}