using System;
using System.Collections.Generic;

namespace OnlineShopApp.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public int? Quantity { get; set; }

    public int? Price { get; set; }
}
