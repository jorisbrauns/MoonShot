using System.Collections.Generic;
using Entities;

namespace WebApi
{
    public interface IPagination<TEntity> where TEntity : BaseEntity
    {
        int Page { get; set; }
        int PageSize { get; set; }
        int TotalItems { get; set; }
        IList<TEntity> Records { get; set; }
    }
}
