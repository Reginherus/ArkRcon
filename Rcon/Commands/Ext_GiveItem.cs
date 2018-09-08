using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rcon.Commands
{
    public class Ext_GiveItem : Command
    {
        private const string Command = "GiveItem";

        public string SteamID { get; set; }

        public string ItemBPPath { get; set; }

        public string Quantity { get; set; }

        public string Quality { get; set; }

        public string ForceBP { get; set; }

        public Ext_GiveItem()
            : base(CommandType.Ext_GiveItem)
        { }

        public Ext_GiveItem(string steamID, string bppath, string quantity, string quality, string forcebp)
            : this()
        {
            SteamID = steamID;
            ItemBPPath = bppath;
            Quantity = quantity;
            Quality = quality;
            ForceBP = forcebp;
        }

        public override string ToString()
        {
            return $"{Command} {SteamID} {ItemBPPath} {Quantity} {Quality} {ForceBP}";
        }
    }
}
