﻿using BlossomiShymae.RiotBlossom.Core;

namespace BlossomiShymae.RiotBlossom.Dto.DataDragon.Item
{
    /// <summary>
    /// UNDOCUMENTED
    /// </summary>
    public record Image
    {
        public string Full { get; init; } = default!;
        public string Sprite { get; init; } = default!;
        public string Group { get; init; } = default!;
        public int X { get; init; }
        public int Y { get; init; }
        public int W { get; init; }
        public int H { get; init; }

        public override string ToString()
        {
            return PrettyPrinter.GetString(this);
        }
    }
}
