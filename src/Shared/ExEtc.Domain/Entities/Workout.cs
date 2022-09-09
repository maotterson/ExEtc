namespace ExEtc.Domain.Entities;
public class Workout
{
    public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
}
