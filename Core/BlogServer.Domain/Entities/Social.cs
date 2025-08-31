using BlogServer.Domain.Entities.Common;

namespace BlogServer.Domain.Entities;

public class Social:BaseEntity
{
    public string Title { get; set; }= string.Empty;
    public string Url { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
}
