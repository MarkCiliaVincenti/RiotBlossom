﻿namespace Gwen.Api
{
    public static class Api
    {
        public delegate T UseByRoutingValue<T>(string routingValue);
    }
}