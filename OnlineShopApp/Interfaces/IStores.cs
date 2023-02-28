using OnlineShopApp.Models;
using System;
using System.Collections.Generic;
namespace OnlineShopApp.Interfaces
{
    public interface IStores
    {
        List<Store> GetStores();
        Store CreateStores(Store store);
    }
}
