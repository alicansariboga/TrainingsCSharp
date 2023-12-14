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
        IResponseDao _responseDao;
        public MessageManager(IMessageDao messageDao)
        {
            _messageDao = messageDao;
        }
        public MessageManager(IResponseDao responseDao)
        {
            _responseDao = responseDao;
        }

        public void Add(Message message)
        {
            _messageDao.Add(message);
        }

        public void Delete(Message message)
        {
            _messageDao.Delete(message);
        }

        public List<Message> GetAll()
        {
            return _messageDao.GetAll();
        }

        public Message GetById(int msgId)
        {
            return _messageDao.GetById(msgId);
        }
    }
}
