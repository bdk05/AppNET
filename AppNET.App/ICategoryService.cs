using AppNET.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNET.App
{
    public interface ICategoryService
    {
        void Create(int id, string name);
        bool Delete(int categoriId);
        IReadOnlyCollection<Category> GetAll();
        Category Update(int categoryId, string newCategoryName);
        Category GetById(int id);
        Category GetAllByProducts(int id);
    }
}
