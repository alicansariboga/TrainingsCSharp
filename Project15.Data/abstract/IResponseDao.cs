using Project15.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project15.Data.@abstract
{
    public interface IResponseDao : IEntityRepository<Response>
    {
        Response GetById(int rId);
    }
}
