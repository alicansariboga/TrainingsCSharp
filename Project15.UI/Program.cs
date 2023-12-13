using Project15.Business.concrete;
using Project15.Data.concrete;
using Project15.Entities;
using System;
using System.Xml.Schema;

namespace Project15.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creatings
            MessageManager messageManager = new MessageManager(new MessageDao());
            try
            {
                Console.WriteLine("----------- CONTACT ME ------------");
                Console.WriteLine("Please enter your name : ");
                var msgFirstName = Console.ReadLine();
                Console.WriteLine("Please enter your surname : ");
                var msgSLastName = Console.ReadLine();
                Console.WriteLine("Please enter e-mail : ");
                var msgEmail = Console.ReadLine();
                Console.WriteLine("Please enter your message : ");
                var msgContent = Console.ReadLine();
                messageManager.Add(new Message { FirstName = msgFirstName, LastName = msgSLastName, EMail = msgEmail, MessageContent = msgContent });

                Console.WriteLine("Your message was sended successfully.");

                var total = messageManager.GetAll().Count;

                Console.WriteLine("----------- INFORMATION -----------");
                Console.WriteLine("Message ID : {0} \nYour Name :  {1} \nYour Surname {2} \nYour E-mail : {3} \nYour Message : {4} ", messageManager.GetById(total).MessageId, messageManager.GetById(total).FirstName, messageManager.GetById(total).LastName, messageManager.GetById(total).EMail, messageManager.GetById(total).MessageContent);

            }
            catch (Exception)
            {
                Console.WriteLine("There is an error.");
                throw;
            }
        }
    }
}
