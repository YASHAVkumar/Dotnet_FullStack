using Microsoft.Extensions.Caching.Distributed;

namespace mvc_project.EMS.Infrasturcture.Cache;

public class RedisService
{
    private readonly IDistributedCache _cache;

    public RedisService(IDistributedCache cache)
    {
        _cache = cache;
    }

    public async Task SetAsync(string key,
                               string value)
    {
        await _cache.SetStringAsync(key,
                                    value);
    }

    public async Task<string?> GetAsync(string key)
    {
        return await _cache.GetStringAsync(key);
    }
}
