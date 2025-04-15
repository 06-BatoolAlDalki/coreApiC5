using System;
using System.Collections.Generic;

namespace coreApiC5.Server.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? CategoryDescription { get; set; }
}
