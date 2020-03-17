using System;
using System.Collections.Generic;

namespace TabletopDirector.DataAccess.Models
{
    public class Campaign
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<GameMaster> GameMasters { get; set; }
        public List<Player> Players { get; set; }
        // TODO: Add campaign based model
    }
}
