using Project15.Business.@abstract;
using Project15.Data.@abstract;
using Project15.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project15.Business.concrete
{
    public class ResponseManager : IResponseService
    {
        IResponseDao _responseDao;
        public ResponseManager(IResponseDao responseDao)
        {
            _responseDao = responseDao;
        }

        public void Add(Response response)
        {
            _responseDao.Add(response);
        }

        public void Delete(Response response)
        {
            _responseDao.Delete(response);
        }

        public List<Response> GetAll()
        {
            return _responseDao.GetAll();
        }

        public Response GetById(int rId)
        {
            return _responseDao.GetById(rId);
        }
    }
}
