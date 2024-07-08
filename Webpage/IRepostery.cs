using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpagemodeol
{
   public  interface IRepostery
    {
        public IEnumerable<webpagemodel> Show();
        public void Create(webpagemodel insert);


    }
}
