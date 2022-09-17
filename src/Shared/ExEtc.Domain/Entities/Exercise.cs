namespace ExEtc.Domain.Entities;
public class Exercise
{
    public ExerciseType Type { get; set; }
    public List<SetInfo> Sets { get; set; } = new List<SetInfo>();
}
