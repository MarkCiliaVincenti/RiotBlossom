﻿using Gwen.Core;
using Gwen.Dto.Riot.Summoner;
using Gwen.Http;
using Gwen.Type;

namespace Gwen.Api.Riot
{
    public interface ISummonerApi
    {
        /// <summary>
        /// Get a summoner by encrypted account ID.
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        Task<SummonerDto> GetByAccountIdAsync(PlatformRoute platformRoute, string accountId);

        /// <summary>
        /// Get a summoner by encrypted ID.
        /// </summary>
        /// <param name="summonerId"></param>
        /// <returns></returns>
        Task<SummonerDto> GetByIdAsync(PlatformRoute platformRoute, string summonerId);

        /// <summary>
        /// Get a summoner by summoner name.
        /// </summary>
        /// <param name="summonerName"></param>
        /// <returns></returns>
        Task<SummonerDto> GetByNameAsync(PlatformRoute platformRoute, string summonerName);

        /// <summary>
        /// Get a summoner by encrypted PUUID.
        /// </summary>
        /// <param name="puuid"></param>
        /// <returns></returns>
        Task<SummonerDto> GetByPuuidAsync(PlatformRoute platformRoute, string puuid);
    }

    internal class SummonerApi : ISummonerApi
    {
        private static readonly string _uri = "/lol/summoner/v4/summoners";
        private static readonly string _summonerByRSOPuuidUri = "/fufillment/v1/summoners/by-puuid/{0}";
        private static readonly string _summonerByAccountIdUri = _uri + "/by-account/{0}";
        private static readonly string _summonerBySummonerNameUri = _uri + "/by-name/{0}";
        private static readonly string _summonerByPuuidUri = _uri + "/by-puuid/{0}";
        private static readonly string _summonerByAccessTokenUri = _uri + "/me";
        private static readonly string _summonerBySummonerIdUri = _uri + "/{0}";
        private readonly ComposableApi<SummonerDto> _summonerDtoApi;

        public SummonerApi(RiotHttpClient riotGamesClient)
        {
            _summonerDtoApi = new(riotGamesClient);
        }

        public async Task<SummonerDto> GetByAccountIdAsync(PlatformRoute platformRoute, string accountId)
            => await _summonerDtoApi.GetValueAsync(PlatformRouteMapper.GetId(platformRoute), string.Format(_summonerByAccountIdUri, accountId));

        public async Task<SummonerDto> GetByNameAsync(PlatformRoute platformRoute, string summonerName)
            => await _summonerDtoApi.GetValueAsync(PlatformRouteMapper.GetId(platformRoute), string.Format(_summonerBySummonerNameUri, summonerName));

        public async Task<SummonerDto> GetByPuuidAsync(PlatformRoute platformRoute, string puuid)
            => await _summonerDtoApi.GetValueAsync(PlatformRouteMapper.GetId(platformRoute), string.Format(_summonerByPuuidUri, puuid));

        public async Task<SummonerDto> GetByIdAsync(PlatformRoute platformRoute, string summonerId)
            => await _summonerDtoApi.GetValueAsync(PlatformRouteMapper.GetId(platformRoute), string.Format(_summonerBySummonerIdUri, summonerId));
    }
}
