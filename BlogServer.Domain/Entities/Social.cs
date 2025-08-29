using BlogServer.Domain.Entities.Common;

namespace BlogServer.Domain.Entities;

public class Social : BaseEntity
{
    public string Title { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}
