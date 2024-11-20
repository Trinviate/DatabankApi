namespace DatabankApi.Contracts.Data;

public class QuestionDto
{
    public Guid ID { get; init; }
    public string Department { get; init; } = default!;
    public string Course { get; init; } = default!;
    public string TopicDescription { get; init; } = default!;
    public string TypeOfQuestion { get; init; } = default!;
    public string Question { get; init; } = default!;
    public string Answer { get; init; } = default!;
    public string AnswerKey { get; init; } = default!;
    public byte[] Image { get; init; } = default!;
}
