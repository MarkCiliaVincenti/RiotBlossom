﻿namespace BlossomiShymae.RiotBlossom.Dto.DataDragon.Champion
{
    /// <summary>
    /// UNDOCUMENTED
    /// </summary>
    public record Passive
    {
        public string Name { get; init; } = default!;
        public string Description { get; init; } = default!;
        public Image Image { get; init; } = new();
    }
}