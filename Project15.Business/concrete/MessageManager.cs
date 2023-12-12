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
    public class MessageManager : IMessageService
    {
        IMessageDao _messageDao;
        public MessageManager(IMessageDao messageDao)
        {
            _messageDao = messageDao;
        }

        public void Add(Message message)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message message)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetAll()
        {
            throw new NotImplementedException();
        }

        public Message GetById(int msgId)
        {
            throw new NotImplementedException();
        }
    }
}
