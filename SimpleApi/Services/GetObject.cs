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

        public async Task<SimpleObject> GetByIdSafeAsync(int id)
        {
            //Using EntityFramework with LINQ ensures a Paramaterized Query, which will not execute unexpected code.
            return await _dbContext.SimpleObjects.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<SimpleObject> GetByIdUnsafeAsync(string id)
        {
            //Using ExecuteSqlRaw with a dynamically constructed query opens up a vulnerability to SQL Injection if input "id" is malicious.
            var query = $"SELECT * FROM SimpleObjects WHERE Id = " + id;
            await _dbContext.Database.ExecuteSqlRawAsync(query);

            return await _dbContext.SimpleObjects.Where(x => x.Id == Convert.ToInt32(id)).FirstOrDefaultAsync();
        }

    }
}
