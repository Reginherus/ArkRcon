using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rcon.Commands
{
    public class Ext_UnlockEngram : Command
    {
        private const string Command = "UnlockEngram";

        public string SteamID { get; set; }

        public string BPPath { get; set; }

        public Ext_UnlockEngram()
            : base(CommandType.Ext_UnlockEngram)
        { }

        public Ext_UnlockEngram(string steamID, string bppath)
            : this()
        {
            SteamID = steamID;
            BPPath = bppath;
        }

        public override string ToString()
        {
            return $"{Command} {SteamID} {BPPath}";
        }
    }
}
