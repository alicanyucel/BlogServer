using BlogServer.Domain.Entities.Common;

namespace BlogServer.Domain.Entities;

public class Meesage:BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public bool IsRead { get; set; }
}
