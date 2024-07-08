using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpagemodeol
{
  public  class WebpageDb:DbContext
    {
        public WebpageDb (DbContextOptions option) : base(option)
        {
        }
        public DbSet<webpagemodel> Webpage { get; set;}
    }
}
