using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rcon.Commands
{
    public class Ext_AddExperience : Command
    {
        private const string Command = "AddExperience";

        public string SteamID { get; set; }

        public string ExpPoints { get; set; }

        public string TribeShare { get; set; }

        public string PreventSharing { get; set; }

        public string ZCoordinate { get; set; }

        public Ext_AddExperience()
            : base(CommandType.Ext_AddExperience)
        { }

        public Ext_AddExperience(string steamid, string exppoints, string tribeshare, string preventsharing)
            : this()
        {
            SteamID = steamid;
            ExpPoints = exppoints;
            TribeShare = tribeshare;
            PreventSharing = preventsharing;
        }
        public override string ToString()
        {
            return $"{Command} {SteamID} {ExpPoints} {TribeShare} {PreventSharing}";
        }
    }
}
