﻿using System.Collections.Immutable;

namespace BlossomiShymae.RiotBlossom.Middleware
{
    /// <summary>
    /// A collection of middlewares used for the HTTP request/execute/response cycle.
    /// </summary>
    public class MiddlewareStack
    {
        public ImmutableArray<IRequestMiddleware> RequestSeries { get; init; } = ImmutableArray<IRequestMiddleware>.Empty;
        public IRetryMiddleware? Retry { get; init; } = null;
        public ImmutableArray<IResponseMiddleware> ResponseSeries { get; init; } = ImmutableArray<IResponseMiddleware>.Empty;

        public MiddlewareStack(bool createLimiter)
        {
            InMemoryCache cache = new();
            List<IRequestMiddleware> requestSeries = new();
            List<IResponseMiddleware> responseSeries = new();
            requestSeries.Add(cache);
            responseSeries.Add(cache);
            if (createLimiter)
            {
                Limiter limiter = new();
                requestSeries.Add(limiter);
                responseSeries.Add(limiter);
            }

            RequestSeries = requestSeries.ToImmutableArray();
            Retry = new Retryer();
            ResponseSeries = responseSeries.ToImmutableArray();
        }
    }
}
