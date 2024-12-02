namespace DatabankApi.Contracts.Request.UserRequest;

public class CreateUserRequest
{
    public Guid ID { get; init; }
    public required string Username { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string Department { get; init; }
    public required string Email { get; init; }
    public Guid TopicManagementID { get; init; }
    public Guid QuestionEntryID { get; init; }
}
