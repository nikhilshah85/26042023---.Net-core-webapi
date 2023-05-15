using System;
using System.Collections.Generic;

namespace repository_pattern_api.Models.SQLServer;

public partial class ProductSql
{
    public int PId { get; set; }

    public string? PName { get; set; }

    public string? PCategory { get; set; }

    public int? PPrice { get; set; }

    public bool? PIsInStock { get; set; }
}
