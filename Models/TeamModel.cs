using System.Collections.Generic;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a team and its members.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// List of team members.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Name of the team.
        /// </summary>
        public string TeamName { get; set; }
    }
}
