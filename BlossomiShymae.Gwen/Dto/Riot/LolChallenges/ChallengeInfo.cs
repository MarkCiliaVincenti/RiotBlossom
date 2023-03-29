﻿namespace BlossomiShymae.Gwen.Dto.Riot.LolChallenges
{
    public record ChallengeInfo
    {
        public long ChallengeId { get; init; }
        public double Percentile { get; init; }
        public string Level { get; init; } = default!;
        public double Value { get; init; }
        public long AchievedTime { get; init; }
    }
}