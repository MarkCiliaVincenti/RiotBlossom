﻿namespace BlossomiShymae.Gwen.XMiddleware
{
    public record XExecuteInfo
    {
        public string RoutingValue { get; init; } = string.Empty;
        public string MethodUri { get; init; } = string.Empty;
    }
}