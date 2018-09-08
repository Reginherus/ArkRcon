using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rcon.Commands
{
    public class Ext_SpawnDino : Command
    {
        private const string Command = "SpawnDino";

        public string SteamID { get; set; }

        public string DinoBPPath { get; set; }

        public string DinoLevel { get; set; }

        public string ForceTame { get; set; }

        public string XCoordinate { get; set; }

        public string YCoordinate { get; set; }

        public string ZCoordinate { get; set; }

        public Ext_SpawnDino()
            : base(CommandType.Ext_SpawnDino)
        { }

        public Ext_SpawnDino(string steamID, string dinoBPPath, string dinoLevel, string forceTame, string xCoordinate, string yCoordinate, string zCoordinate)
            : this()
        {
            SteamID = steamID;
            DinoBPPath = dinoBPPath;
            DinoLevel = dinoLevel;
            ForceTame = forceTame;
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            ZCoordinate = zCoordinate;
        }
        public Ext_SpawnDino(string steamID, string dinoBPPath, string dinoLevel, string forceTame)
            : this()
        {
            SteamID = steamID;
            DinoBPPath = dinoBPPath;
            DinoLevel = dinoLevel;
            ForceTame = forceTame;
        }
        
        public override string ToString()
        {
            return $"{Command} {SteamID} {DinoBPPath} {DinoLevel} {XCoordinate} {YCoordinate} {ZCoordinate}";
        }
    }
}
