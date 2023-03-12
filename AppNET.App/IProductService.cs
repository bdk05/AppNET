using AppNET.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNET.App
{
    public interface IProductService
    {
        void Create(int id, string name, int stok, decimal salePrice, decimal buyingSale, int categoryId);
        bool Delete(int productId);
        IReadOnlyCollection<Product> GetAll();
      //  Product Update(int productId, string newName, int newStok, decimal newPrice, int categoryId, DateTime createdDate, DateTime updatedDate);
        Product Update(int productId, Product newProduct);
        Product GetById(int id);


    }
}
