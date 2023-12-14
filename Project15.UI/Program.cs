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
            // Creatings Obj
            MessageManager messageManager = new MessageManager(new MessageDao());
            ResponseManager responseManager = new ResponseManager(new ResponseDao());

            //User Message
            int mtotal = 0;
            try
            {
                Console.WriteLine("----------- CONTACT ME ------------\n");
                Console.WriteLine("Please enter your name : ");
                var msgFirstName = Console.ReadLine();
                Console.WriteLine("Please enter your surname : ");
                var msgSLastName = Console.ReadLine();
                Console.WriteLine("Please enter e-mail : ");
                var msgEmail = Console.ReadLine();
                Console.WriteLine("Please enter your message : ");
                var msgContent = Console.ReadLine();
                messageManager.Add(new Message { FirstName = msgFirstName, LastName = msgSLastName, EMail = msgEmail, MessageContent = msgContent });

                Console.WriteLine("\n-------------- RESULT -------------\n");
                Console.WriteLine("Your message was sended successfully.\n");

                var total = messageManager.GetAll().Count;

                /*
                Console.WriteLine("----------- INFORMATION -----------");

                Console.WriteLine("Message ID : {0} \nYour Name :  {1} \nYour Surname {2} \nYour E-mail : {3} \nYour Message : {4} ", messageManager.GetById(total).MessageId, messageManager.GetById(total).FirstName, messageManager.GetById(total).LastName, messageManager.GetById(total).EMail, messageManager.GetById(total).MessageContent);
                */
                mtotal = total;
            }
            catch (Exception)
            {
                Console.WriteLine("There is an error.");
                throw;
            }

            Console.WriteLine("------------- RESPONSE ------------\n");
            // Assignments
            var resMsgId = messageManager.GetById(mtotal).MessageId;
            var resUsrName = (messageManager.GetById(mtotal).FirstName + " " + messageManager.GetById(mtotal).LastName);
            var resEmail = messageManager.GetById(mtotal).EMail;
            var resContent = ("Sayin {0}, talebiniz alinmistir. \nEn kisa surede donus saglayacagiz. Iyi gunler dileriz.");
            Console.WriteLine("To: {0}",resEmail);
            Console.WriteLine(resContent, resUsrName);
            Console.WriteLine("\nX Tech.");

            responseManager.Add(new Response { MessageId = resMsgId, UserName = resUsrName, EMail = resEmail, MessageContent = resContent });
        }
    }
}
