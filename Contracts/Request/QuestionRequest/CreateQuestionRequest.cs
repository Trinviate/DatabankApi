namespace DatabankApi.Contracts.Request.QuestionRequest;

public class CreateQuestionRequest
{
    public Guid ID { get; init; } = default!;
    public required string Department { get; init; }
    public required string Course { get; init; }
    public required string TopicDescription { get; init; }
    public required string TypeOfQuestion { get; init; }
    public required string Question { get; init; }
    public required string Answer { get; init; }
    public required string AnswerKey { get; init; }
    public byte[] Image { get; init; } = default!;
}
