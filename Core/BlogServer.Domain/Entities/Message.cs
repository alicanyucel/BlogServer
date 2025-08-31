using BlogServer.Domain.Entities.Common;

namespace BlogServer.Domain.Entities;

public class Message:BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Subject { get; set; }=string.Empty;
    public string Body { get; set; } = string.Empty;
    public bool IsRead { get; set; }

}
