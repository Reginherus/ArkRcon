using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rcon.Commands
{
    public class Ext_GiveItemToAll : Command
    {
        private const string Command = "GiveItemToAll";

        public string ItemBPPath { get; set; }

        public string Quantity { get; set; }

        public string Quality { get; set; }

        public string ForceBP { get; set; }

        public Ext_GiveItemToAll()
            : base(CommandType.Ext_GiveItemToAll)
        { }

        public Ext_GiveItemToAll(string bppath, string quantity, string quality, string forcebp)
            : this()
        {
            ItemBPPath = bppath;
            Quantity = quantity;
            Quality = quality;
            ForceBP = forcebp;
        }

        public override string ToString()
        {
            return $"{Command} {ItemBPPath} {Quantity} {Quality} {ForceBP}";
        }
    }
}
