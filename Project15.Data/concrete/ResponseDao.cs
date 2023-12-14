using Project15.Data.@abstract;
using Project15.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project15.Data.concrete
{
    public class ResponseDao : IResponseDao
    {
        public void Add(Response response)
        {
            using (MessageContext context = new MessageContext())
            {
                context.Responses.Add(response);
                context.SaveChanges();
            }
        }

        public void Delete(Response response)
        {
            using (MessageContext context = new MessageContext())
            {
                context.Responses.Remove(context.Responses.SingleOrDefault(p => p.ResponseId == response.ResponseId));
                context.SaveChanges();
            }
        }

        public List<Response> GetAll()
        {
            using (MessageContext context = new MessageContext())
            {
                return context.Responses.ToList();
            }
        }

        public Response GetById(int rId)
        {
            using (MessageContext context = new MessageContext())
            {
                return context.Responses.SingleOrDefault(p => p.ResponseId == rId);
            }
        }
    }
}
