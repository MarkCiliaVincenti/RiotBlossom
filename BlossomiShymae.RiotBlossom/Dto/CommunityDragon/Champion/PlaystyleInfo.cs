﻿using BlossomiShymae.RiotBlossom.Core;

namespace BlossomiShymae.RiotBlossom.Dto.CommunityDragon.Champion
{
    /// <summary>
    /// UNDOCUMENTED
    /// </summary>
    public record PlaystyleInfo
    {
        public int Damage { get; init; }
        public int Durability { get; init; }
        public int CrowdControl { get; init; }
        public int Mobility { get; init; }
        public int Utility { get; init; }

        public override string ToString()
        {
            return PrettyPrinter.GetString(this);
        }
    }
}
