using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiEF.Models
{
    public class BookServiceContext : DbContext
    {
        public BookServiceContext() : base("name=BookServiceContext")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        }

        public System.Data.Entity.DbSet<WebApiEF.Models.Author> Authors { get; set; }

        public System.Data.Entity.DbSet<WebApiEF.Models.Book> Books { get; set; }

    }
}
