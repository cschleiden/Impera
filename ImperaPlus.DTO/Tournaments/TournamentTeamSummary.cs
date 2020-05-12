﻿using System;

namespace ImperaPlus.DTO.Tournaments
{
    /// <summary>
    /// Summary of a team in a tournament
    /// </summary>
    public class TournamentTeamSummary
    {
        /// <summary>
        /// Unique identifier of team
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Name of this team
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// If joining this team requires a password
        /// </summary>
        public bool RequiresPassword { get; set; }

        /// <summary>
        /// Id of player who created the team
        /// </summary>
        public string CreatedById { get; set; }

        /// <summary>
        /// Order of team within group (if groups are enabled)
        /// </summary>
        public int GroupOrder { get; set; }

        /// <summary>
        /// State of team
        /// </summary>
        public TournamentTeamState State { get; set; }
    }
}
