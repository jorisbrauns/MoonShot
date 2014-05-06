using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public interface IEFUnitOfWork<TContext> : IUnitOfWork where TContext : IEntityContext
    {
        TContext Context { get; set; }
    }
}
