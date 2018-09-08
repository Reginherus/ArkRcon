using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rcon.Commands
{
    public class Ext_SetPlayerPos : Command
    {
        private const string Command = "SetPlayerPos";

        public string SteamID { get; set; }

        public string XCoordinate { get; set; }

        public string YCoordinate { get; set; }

        public string ZCoordinate { get; set; }

        public Ext_SetPlayerPos()
            : base(CommandType.Ext_SetPlayerPos)
        { }

        public Ext_SetPlayerPos(string steamID, string xCoordinate, string yCoordinate, string zCoordinate)
            : this()
        {
            SteamID = steamID;
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            ZCoordinate = zCoordinate;
        }

        public override string ToString()
        {
            return $"{Command} {SteamID} {XCoordinate} {YCoordinate} {ZCoordinate}";
        }
    }
}
