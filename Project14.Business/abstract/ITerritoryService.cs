using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Business.@abstract
{
    public interface ITerritoryService
    {
        List<Territory> GetAll();
        Territory GetById(int id);
        void Add(Territory territory);
        void Update(Territory territory);
        void Delete(Territory territory);
    }
}
