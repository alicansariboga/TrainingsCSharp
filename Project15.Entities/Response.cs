using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Project15.Entities
{
    public class Response : IEntity
    {
        public int ResponseId { get; set; } // PK
        public int MessageId { get; set; } // FK
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string MessageContent { get; set; }
    }
}
