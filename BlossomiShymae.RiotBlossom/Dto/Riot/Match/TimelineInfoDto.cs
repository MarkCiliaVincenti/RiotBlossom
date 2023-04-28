﻿using BlossomiShymae.RiotBlossom.Core;
using System.Collections.Immutable;

namespace BlossomiShymae.RiotBlossom.Dto.Riot.Match
{
    /// <summary>
    /// UNDOCUMENTED
    /// </summary>
    public record TimelineInfoDto
    {
        public long FrameInterval { get; init; }
        public ImmutableList<Frame> Frames { get; init; } = ImmutableList<Frame>.Empty;
        public long GameId { get; init; }
        public ImmutableList<TimelineParticipant> Participants { get; init; } = ImmutableList<TimelineParticipant>.Empty;

        public override string ToString()
        {
            return PrettyPrinter.GetString(this);
        }
    }
}
