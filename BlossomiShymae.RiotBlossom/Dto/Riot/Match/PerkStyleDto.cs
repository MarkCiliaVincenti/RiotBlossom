﻿using BlossomiShymae.RiotBlossom.Core;
using System.Collections.Immutable;

namespace BlossomiShymae.RiotBlossom.Dto.Riot.Match
{
    public record PerkStyleDto
    {
        /// <summary>
        /// The description of perk style.
        /// </summary>
        public string Description { get; init; } = default!;
        /// <summary>
        /// The selected perk styles.
        /// </summary>
        public ImmutableList<PerkStyleSelectionDto> Selections { get; init; } = ImmutableList<PerkStyleSelectionDto>.Empty;
        /// <summary>
        /// The style ID.
        /// </summary>
        public int Style { get; init; }

        public override string ToString()
        {
            return PrettyPrinter.GetString(this);
        }
    }
}
