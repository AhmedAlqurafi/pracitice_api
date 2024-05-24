using System.Linq.Expressions;
using Practice_MagicVilla.Models;

namespace Practice_MagicVilla.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);

    }
}