using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rcon.Commands
{
    public class Ext_TeleportAllPlayers : Command
    {
        private const string Command = "TeleportAllPlayers";

        public string XCoordinate { get; set; }

        public string YCoordinate { get; set; }

        public string ZCoordinate { get; set; }

        public Ext_TeleportAllPlayers()
            : base(CommandType.Ext_TeleportAllPlayers)
        { }

        public Ext_TeleportAllPlayers(string xCoordinate, string yCoordinate, string zCoordinate)
            : this()
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            ZCoordinate = zCoordinate;
        }

        public override string ToString()
        {
            return $"{Command} {XCoordinate} {YCoordinate} {ZCoordinate}";
        }
    }
}
