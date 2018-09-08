using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rcon.Commands
{
    public class Ext_ListPlayerDinos : Command
    {
        private const string Command = "ListPlayerDinos";

        public string SteamID { get; set; }

        public Ext_ListPlayerDinos()
            : base(CommandType.Ext_ListPlayerDinos)
        { }

        public Ext_ListPlayerDinos(string steamid)
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
