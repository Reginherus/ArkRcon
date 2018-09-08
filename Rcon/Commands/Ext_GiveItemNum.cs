using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rcon.Commands
{
    public class Ext_GiveItemNum : Command
    {
        private const string Command = "GiveItem";

        public string SteamID { get; set; }

        public string ItemID { get; set; }

        public string Quantity { get; set; }

        public string Quality { get; set; }

        public string ForceBP { get; set; }

        public Ext_GiveItemNum()
            : base(CommandType.Ext_GiveItem)
        { }

        public Ext_GiveItemNum(string steamID, string itemid, string quantity, string quality, string forcebp)
            : this()
        {
            SteamID = steamID;
            ItemID = itemid;
            Quantity = quantity;
            Quality = quality;
            ForceBP = forcebp;
        }

        public override string ToString()
        {
            return $"{Command} {SteamID} {ItemID} {Quantity} {Quality} {ForceBP}";
        }
    }
}
