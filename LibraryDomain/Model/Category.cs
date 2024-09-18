using System;
using System.Collections.Generic;

namespace LibraryDomain;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Info { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
