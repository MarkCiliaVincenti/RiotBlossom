﻿using BlossomiShymae.RiotBlossom.Core;

namespace BlossomiShymae.RiotBlossom.Dto.Riot.Match
{
    public record ObjectiveDto
    {
        /// <summary>
        /// Whether team got the first kill for the objective.
        /// </summary>
        public bool First { get; init; }
        /// <summary>
        /// The amount of times this objective was killed.
        /// </summary>
        public int Kills { get; init; }

        public override string ToString()
        {
            return PrettyPrinter.GetString(this);
        }
    }
}
