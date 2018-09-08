using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rcon.Commands
{
    public class Ext_AddDinoExperience : Command
    {
        private const string Command = "AddDinoExperience";

        public string DinoID1 { get; set; }

        public string DinoID2 { get; set; }

        public Ext_AddDinoExperience()
            : base(CommandType.Ext_AddDinoExperience)
        { }

        public Ext_AddDinoExperience(string dinoId1, string dinoId2)
            : this()
        {
            DinoID1 = dinoId1;
            DinoID2 = dinoId2;
        }
        public override string ToString()
        {
            return $"{Command} {DinoID1} {DinoID1}";
        }
    }
}
