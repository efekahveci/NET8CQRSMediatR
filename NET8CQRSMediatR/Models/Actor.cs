namespace NET8CQRSMediatR.Models;

public class Actor
{
    public Guid ActorId { get; set; } = new Guid();
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}
