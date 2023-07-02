using System.Collections.Generic;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a tournament model.
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Gets or sets the name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Gets or sets the entry fee of the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Gets or sets the list of entered teams.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Gets or sets the list of prizes.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Gets or sets the list of rounds.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}

/* 
We initialize all lists right away because we don't want to have to check for nulls later on. 
 



*/