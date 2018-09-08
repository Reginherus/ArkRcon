using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rcon.Commands
{
    public class Ext_GetTribeIdOfPlayer : Command
    {
        private const string Command = "GetTribeIdOfPlayer";

        public string SteamID { get; set; }

        public Ext_GetTribeIdOfPlayer()
            : base(CommandType.Ext_GetTribeIdOfPlayer)
        { }

        public Ext_GetTribeIdOfPlayer(string steamid)
            : this()
        {
            SteamID = steamid;
        }
        public override string ToString()
        {
            return $"{Command} {SteamID}";
        }
    }
}
