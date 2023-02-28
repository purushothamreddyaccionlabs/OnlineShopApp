using System;
using System.Collections.Generic;

namespace OnlineShopApp.Models;

public partial class StoreCategory
{
    public int StoreId { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;
}
