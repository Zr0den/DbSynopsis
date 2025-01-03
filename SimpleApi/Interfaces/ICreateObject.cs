using SimpleApi.Entities;

namespace SimpleApi.Interfaces
{
    public interface ICreateObject
    {
        Task<SimpleObject> CreateAsync(SimpleObject simpleObject);
    }
}
