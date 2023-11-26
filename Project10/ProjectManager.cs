using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10
{
    class ProjectManager
    {
        public void Add(IPerson personManager)
        {
            personManager.Add();
        }
        public void Delete(IPerson personManager)
        {
            personManager.Delete();
        }
        public void Update(IPerson personManager)
        {
            personManager.Update();
        }
    }
}
