using AppNET.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNET.App
{
    public interface ISalesService
    {
        void Create(int id, Transaction gelir, Transaction gider);
        bool Delete(int id);
        IReadOnlyCollection<Vault> GetAll();
        Vault Update(int id, Transaction gelir, Transaction gider);
        Vault GetById(int id);

    }
}
