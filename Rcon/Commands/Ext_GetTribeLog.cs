using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rcon.Commands
{
    public class Ext_GetTribeLog : Command
    {
        private const string Command = "GetTribeLog";

        public string TribeID { get; set; }

        public Ext_GetTribeLog()
            : base(CommandType.Ext_GetTribeLog)
        { }

        public Ext_GetTribeLog(string tribeid)
            : this()
        {
            TribeID = tribeid;
        }
        public override string ToString()
        {
            return $"{Command} {TribeID}";
        }
    }
}
