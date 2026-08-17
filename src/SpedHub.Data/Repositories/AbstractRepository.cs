using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedHub.Data.Repositories
{
    public abstract class AbstractRepository : IDisposable
    {
        protected SpedHubDbContext Context;

        protected AbstractRepository(SpedHubDbContext context)
        {
            Context = context;
        }

        protected abstract Task<bool> Exists(int id);

        public void Dispose() => Context.Dispose();
    }
}
