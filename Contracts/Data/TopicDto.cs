namespace DatabankApi.Contracts.Data;

public class TopicDto
{
    public Guid ID { get; init; }
    public string Course { get; init; } = default!;
    public string Semester { get; init; } = default!;
    public string TopicCode { get; init; } = default!;
    public string TopicDescription { get; init; } = default!;
    public int TopicYear { get; init; }

}
