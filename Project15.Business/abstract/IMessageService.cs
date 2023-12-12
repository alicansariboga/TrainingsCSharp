using Project15.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project15.Business.@abstract
{
    public interface IMessageService
    {
        List<Message> GetAll();
        Message GetById(int msgId);
        void Add(Message message);
        void Delete(Message message);
    }
}
