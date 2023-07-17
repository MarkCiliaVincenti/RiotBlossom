﻿namespace BlossomiShymae.RiotBlossom.Dto.Riot.LorMatch
{
    public record MatchDto : DataObject
    {
        /// <summary>
        /// The match metadata.
        /// </summary>
        public MetadataDto Metadata { get; init; } = new();
        /// <summary>
        /// The match info.
        /// </summary>
        public InfoDto Info { get; init; } = new();
    }
}
