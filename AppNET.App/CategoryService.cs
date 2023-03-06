using AppNET.Domain.Entities;
using AppNET.Domain.Interfaces;
using AppNET.Infrastructure;
using AppNET.Infrastructure.IOToTXT;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace AppNET.App
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _repository;

        public CategoryService()
        {
            _repository = IOCContainer.Resolve<IRepository<Category>>();
        }
        public void Create(int id, string name)
        {
            //validation
            //business rule
            //create operation
            //  TextFileRepository<Category> repo = new TextFileRepository<Category>();
            //var repo = IOCContainer.Resolve<IRepository<Category>>();
            if (string.IsNullOrWhiteSpace(name)) 
                throw new ArgumentNullException("Kattegori Bulunamadi");
            
            var oldCategory= _repository.GetList().FirstOrDefault(x=>x.Name==name);
            if (oldCategory != null)
                return;//yani çık programdan diyoruz.
            
            Category category = new Category();
            category.Id = id;
            category.Name = name.ToUpper();
            _repository.Add(category);

        }

        public bool Delete(int categoriId)
        {
            
            return _repository.Remove(categoriId);
        }

        public IReadOnlyCollection<Category> GetAll()
        {
            return _repository.GetList().ToList().AsReadOnly();
        }

        public Category Update(int categoryId, string newCategoryName)
        {
            Category category=new Category();   
            category.Id = categoryId;   
            category.Name = newCategoryName.ToUpper();
            return _repository.Update(categoryId, category);
        }
    }
}