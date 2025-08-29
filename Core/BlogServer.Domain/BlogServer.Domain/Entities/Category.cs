using BlogServer.Domain.Entities.Common;

namespace BlogServer.Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public IList<Blog> Blogs { get; set; } // 1 to many relationship

}
