using Project15.Data.@abstract;
using Project15.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project15.Data.concrete
{
    public class MessageDao : IMessageDao
    {
        public void Add(Message message)
        {
            using(MessageContext context = new MessageContext())
            {
                context.Messages.Add(message);
                context.SaveChanges();
            }
        }

        public void Delete(Message message)
        {
            using (MessageContext context = new MessageContext())
            {
                //context.Messages.Remove(message);
                context.Messages.Remove(context.Messages.SingleOrDefault(p => p.MessageId == message.MessageId));
                context.SaveChanges();
            }
        }

        public List<Message> GetAll()
        {
            using (MessageContext context = new MessageContext())
            {
                return context.Messages.ToList();
            }
        }

        public Message GetById(int msgId)
        {
            using (MessageContext context = new MessageContext())
            {
                return context.Messages.SingleOrDefault(p => p.MessageId == msgId);
            }
        }
    }
}
