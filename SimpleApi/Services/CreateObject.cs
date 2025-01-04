using SimpleApi.DB;
using SimpleApi.Entities;
using System;

namespace SimpleApi.Services
{
    public class CreateObject
    {
        private readonly SQLDbContext _dbContext;

        public CreateObject(SQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<SimpleObject> CreateAsync(SimpleObject simpleObject)
        {
            _dbContext.SimpleObjects.Add(simpleObject);
            await _dbContext.SaveChangesAsync();
            return simpleObject;
        }
    }
}
