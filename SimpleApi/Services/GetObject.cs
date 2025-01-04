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
        public async Task<SimpleObject> GetByIdAsync(string id)
        {
            var query = $"SELECT * FROM SimpleObjects WHERE Id = " + id;
            await _dbContext.Database.ExecuteSqlRawAsync(query);

            return await _dbContext.SimpleObjects.Where(x => x.Id == Convert.ToInt32(id)).FirstOrDefaultAsync();
        }
    }
}
