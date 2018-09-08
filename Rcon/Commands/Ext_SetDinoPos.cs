using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rcon.Commands
{
    public class Ext_SetDinoPos : Command
    {
        private const string Command = "SetDinoPos";

        public string DinoID1 { get; set; }

        public string DinoID2 { get; set; }

        public string XCoordinate { get; set; }

        public string YCoordinate { get; set; }

        public string ZCoordinate { get; set; }

        public Ext_SetDinoPos()
            : base(CommandType.Ext_SetDinoPos)
        { }

        public Ext_SetDinoPos(string dinoId1, string dinoId2, string xCoordinate, string yCoordinate, string zCoordinate)
            : this()
        {
            DinoID1 = dinoId1;
            DinoID2 = dinoId2;
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            ZCoordinate = zCoordinate;
        }
        public override string ToString()
        {
            return $"{Command} {DinoID1} {DinoID1} {XCoordinate} {YCoordinate} {ZCoordinate}";
        }
    }
}
