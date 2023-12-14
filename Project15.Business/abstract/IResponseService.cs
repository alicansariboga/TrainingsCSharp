using Project15.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project15.Business.@abstract
{
    public interface IResponseService
    {
        List<Response> GetAll();
        Response GetById(int rId);
        void Add(Response response);
        void Delete(Response response);
    }
}
