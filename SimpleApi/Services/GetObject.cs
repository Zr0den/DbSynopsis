using Microsoft.EntityFrameworkCore;
using SimpleApi.DB;
using SimpleApi.Entities;

namespace SimpleApi.Services
{
    public class GetObject
    {
        private readonly SQLDbContext _dbContext;

        public GetObject(SQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<SimpleObject>> GetAllAsync()
        {
            return await _dbContext.SimpleObjects.ToListAsync();
        }
    }
}
