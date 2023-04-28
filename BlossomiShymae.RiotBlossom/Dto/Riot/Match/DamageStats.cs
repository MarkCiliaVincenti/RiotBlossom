﻿using BlossomiShymae.RiotBlossom.Core;

namespace BlossomiShymae.RiotBlossom.Dto.Riot.Match
{
    /// <summary>
    /// UNDOCUMENTED
    /// </summary>
    public record DamageStats
    {
        public long MagicDamageDone { get; init; }
        public long MagicDamageDoneToChampions { get; init; }
        public long MagicDamageTaken { get; init; }
        public long PhysicalDamageDone { get; init; }
        public long PhysicalDamageDoneToChampions { get; init; }
        public long PhysicalDamageTaken { get; init; }
        public long TotalDamageDone { get; init; }
        public long TotalDamageDoneToChampions { get; init; }
        public long TotalDamageTaken { get; init; }
        public long TrueDamageDone { get; init; }
        public long TrueDamageDoneToChampions { get; init; }
        public long TrueDamageTaken { get; init; }

        public override string ToString()
        {
            return PrettyPrinter.GetString(this);
        }
    }
}
