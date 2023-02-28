using OnlineShopApp.Interfaces;
using OnlineShopApp.Models;

namespace OnlineShopApp.ServieceLayer
{
    public class StoresServices:IStores
    {
        private  CommerceContext _dbcontent;

        public StoresServices(CommerceContext store)
        {
            _dbcontent = store;
        }

        public Store CreateStores(Store store)
        {
            _dbcontent.Stores.Add(store);
            _dbcontent.SaveChanges();
            return store;
        }

        List<Store>IStores.GetStores()
        {
            return _dbcontent.Stores.ToList();
        }


    }
}
