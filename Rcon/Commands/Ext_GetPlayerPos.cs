using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rcon.Commands
{
    public class Ext_GetPlayerPos : Command
    {
        private const string Command = "GetPlayerPos";

        public string SteamID { get; set; }

        public Ext_GetPlayerPos()
            : base(CommandType.Ext_GetPlayerPos)
        { }

        public Ext_GetPlayerPos(string steamid)
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
