using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rcon.Commands
{
    public class Ext_ScriptCommand : Command
    {
        private const string Command = "ScriptCommand";

        public string ScriptCommand { get; set; }

        public string SteamID{ get; set; }

        public Ext_ScriptCommand()
            : base(CommandType.Ext_ScriptCommand)
        { }

        public Ext_ScriptCommand(string steamID, string scriptcommand)
            : this()
        {
            SteamID = steamID;
            ScriptCommand = scriptcommand;
        }
        public override string ToString()
        {
            return $"{Command} {SteamID} {ScriptCommand}";
        }
    }
}
