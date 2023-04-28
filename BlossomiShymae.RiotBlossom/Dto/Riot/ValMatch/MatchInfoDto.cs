﻿using BlossomiShymae.RiotBlossom.Core;

namespace BlossomiShymae.RiotBlossom.Dto.Riot.ValMatch
{
    public record MatchInfoDto
    {
        public string MatchId { get; init; } = default!;
        public string MapId { get; init; } = default!;
        public int GameLengthMillis { get; init; }
        public long GameStartMillis { get; init; }
        public string ProvisioningFlowId { get; init; } = default!;
        public bool IsCompleted { get; init; }
        public string CustomGameName { get; init; } = default!;
        public string QueueId { get; init; } = default!;
        public string GameMode { get; init; } = default!;
        public bool IsRanked { get; init; }
        public string SeasonId { get; init; } = default!;

        public override string ToString()
        {
            return PrettyPrinter.GetString(this);
        }
    }
}
