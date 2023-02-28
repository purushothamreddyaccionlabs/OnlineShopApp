﻿using System;
using System.Collections.Generic;

namespace OnlineShopApp.Models;

public partial class ProductCategory
{
    public int CategoryId { get; set; }

    public int ProductId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
