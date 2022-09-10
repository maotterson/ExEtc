namespace ExEtc.Domain.Entities;
public class Exercise
{
    public ExerciseType Type { get; set; }
    public Collection<SetInfo> Sets { get; set; } = new Collection<SetInfo>();
}
