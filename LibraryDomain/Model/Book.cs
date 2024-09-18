using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryDomain;

public partial class Book
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    [Display(Name = "Author")]
    public int AuthorId { get; set; }

    [Display(Name = "Category")]
    public int CategoryId { get; set; }

    [Display(Name="Cover")]
    public string? FileLink { get; set; }

    public virtual Author Author { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;
}
