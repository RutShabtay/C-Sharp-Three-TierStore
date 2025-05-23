﻿
namespace BlApi
{
    public interface IProduct
    {
        int Create(BO.Product item);
        BO.Product? Read(int id);
        BO.Product? Read(Func<DO.Product, bool> filter);
        List<BO.Product> ReadAll(Func<DO.Product, bool>? filter = null);
        void Update(BO.Product item);
        void Delete(int id);
        List<BO.SaleInProduct>? GetActiveSales(int productId, bool isPreferredCustomer = true);
    }
}
