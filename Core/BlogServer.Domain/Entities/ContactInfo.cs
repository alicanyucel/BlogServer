

using BlogServer.Domain.Entities.Common;

namespace BlogServer.Domain.Entities;

public class ContactInfo : BaseEntity
{
    public string Address { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string MapUrl { get; set; } = string.Empty;
}
