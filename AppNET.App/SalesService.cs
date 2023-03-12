using AppNET.Domain.Entities;
using AppNET.Domain.Interfaces;
using AppNET.Infrastructure;

namespace AppNET.App
{
    public class SalesService : ISalesService
    {
        private readonly IRepository<Vault> _repository;

        public SalesService()
        {
            _repository = IOCContainer.Resolve<IRepository<Vault>>();
        }

        public void Create(int id=0, Transaction gelir=null, Transaction gider=null)
        {
      
            var vault = new Vault();
            vault.Id = _repository.GetList().Count() + 1;
            vault.Gelir = gelir;
            vault.Gider = gider;
            _repository.Add(vault);
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Vault> GetAll()
        {
            return _repository.GetList().ToList().AsReadOnly();
        }

        public Vault GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Vault Update(int id, Transaction gelir, Transaction gider)
        {
            throw new NotImplementedException();
        }
    }
}
