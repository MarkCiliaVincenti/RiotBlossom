﻿namespace Gwen.Dto.Riot.Clash
{
    public record TournamentPhaseDto
    {
        /// <summary>
        /// The tournament phase ID.
        /// </summary>
        public int Id { get; init; }
        /// <summary>
        /// The registered time of the tournament phase.
        /// </summary>
        public long RegistrationTime { get; init; }
        /// <summary>
        /// The starting time of tournament phase.
        /// </summary>
        public long StartTime { get; init; }
        /// <summary>
        /// Whether the tournament phase will occur for totes' whatever reason. :3
        /// </summary>
        public bool Cancelled { get; init; }
    }
}