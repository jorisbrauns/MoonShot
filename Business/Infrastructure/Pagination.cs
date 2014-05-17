using System.Collections.Generic;
using Entities;

namespace Business
{
    public abstract class PaginationBase<TEntity> : IPagination<TEntity> where TEntity : BaseEntity 
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public IList<TEntity> Records { get; set; }
    }
}
