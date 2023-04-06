﻿using System.Collections.Concurrent;
using System.Runtime.Caching;

namespace BlossomiShymae.RiotBlossom.Middleware
{
    /// <summary>
    /// The default middleware implementation for caching associated response data. Data will be 
    /// removed when the cache count limit is reached. Data will also expire after a determined amount
    /// of time passes.
    /// </summary>
    public class InMemoryCache : IRequestMiddleware, IResponseMiddleware
    {
        private static readonly MemoryCache s_cache = MemoryCache.Default;
        private static readonly ConcurrentDictionary<string, long> s_counter = new();
        /// <summary>
        /// The maximum amount of items permitted to the cache.
        /// </summary>
        public long CacheSize { get; init; } = 1000;
        /// <summary>
        /// The expiration of a cache item in hours.
        /// </summary>
        public int CacheExpiration { get; init; } = 6;

        public Task UseRequestAsync(ExecuteInfo info, HttpRequestMessage req, Action next, Action<byte[]> hit)
        {
            string key = req.RequestUri?.OriginalString ?? string.Empty;
            bool isHit = false;

            if (!string.IsNullOrEmpty(key))
            {
                try
                {
                    var res = (byte[])s_cache[key];
                    if (res != null)
                    {
                        isHit = true;
                        bool isValue = s_counter.TryGetValue(key, out long count);
                        if (isValue)
                            s_counter[key] = count + 1;
                        else
                            s_counter[key] = 0;

                        hit(res);
                    }
                    else
                    {
                        s_counter.TryRemove(key, out long _);
                    }
                }
                catch (System.Exception) { }
            }
            if (!isHit)
                next();
            return Task.CompletedTask;
        }

        public async Task UseResponseAsync(ExecuteInfo info, HttpResponseMessage res, Action next)
        {

            string key = res.RequestMessage?.RequestUri?.OriginalString ?? string.Empty;
            if (!string.IsNullOrEmpty(key) && res.IsSuccessStatusCode)
            {
                // Remove items from the cache that are the less used
                if (s_cache.GetCount() > CacheSize)
                {
                    var items = s_counter
                        .ToList()
                        .OrderBy(x => x.Value)
                        .Take((int)(CacheSize / 5));

                    foreach (var item in items)
                    {
                        s_cache.Remove(item.Key);
                        s_counter.TryRemove(item);
                    }
                }

                if (res.IsSuccessStatusCode)
                {
                    byte[] data = await res.Content.ReadAsByteArrayAsync();
                    s_cache.Add(key, data, new CacheItemPolicy
                    {
                        AbsoluteExpiration = DateTimeOffset.Now.AddHours(CacheExpiration)
                    });
                }
            }
            next();
        }
    }
}
