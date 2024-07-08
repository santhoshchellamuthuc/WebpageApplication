using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpagemodeol
{
 public class Repostery:IRepostery
    {
        private readonly WebpageDb refer;
        public Repostery(WebpageDb reference)
        {
            refer = reference;
        }
        public IEnumerable<webpagemodel> Show()
        {
            try
            {
                return refer.Webpage.ToList();

            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Create(webpagemodel insert)
        {
            try
            {
                refer.Add<webpagemodel>(insert);
                refer.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
