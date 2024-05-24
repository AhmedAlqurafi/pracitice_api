using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Practice_MagicVilla.Data;
using Practice_MagicVilla.Models;
using Practice_MagicVilla.Repository.IRepository;

namespace Practice_MagicVilla.Repository
{

    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdateDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}