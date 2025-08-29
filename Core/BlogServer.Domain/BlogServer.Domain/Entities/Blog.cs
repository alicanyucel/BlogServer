using BlogServer.Domain.Entities.Common;

namespace BlogServer.Domain.Entities;

public class Blog : BaseEntity
{
    public string Title { get; set; }
    public string CoverImage { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; } // 1 to many relationship
}