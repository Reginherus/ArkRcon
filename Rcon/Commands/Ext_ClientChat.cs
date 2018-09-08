using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rcon.Commands
{
    public class Ext_ClientChat : Command
    {
        private const string Command = "ClientChat";

        public string Message { get; set; }

        public string Name { get; set; }

        public Ext_ClientChat()
            : base(CommandType.Ext_ClientChat)
        { }

        public Ext_ClientChat(string message, string name)
            : this()
        {
            Message = message;
            Name = Name;
        }

        public override string ToString()
        {
            return $"{Command} \'{Message}\' { Name }";
        }
    }
}
