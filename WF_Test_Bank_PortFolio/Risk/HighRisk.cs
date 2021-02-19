using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Test_Bank_PortFolio.Trades;


namespace WF_Test_Bank_PortFolio.Risk
{
    class HighRisk : IRisk
    {
        public string Type { get; private set; }

        public bool CalculaRisk(ITrade trade)
        {
            if (trade.Value > 1000000 && trade.ClientSector.Equals(SectorRisk.Private.ToString()))
            {
                this.Type = TypeRisk.HighRisk.ToString().ToUpper();

                return true;
            }

            this.Type = NoneRisk.NONERISK.ToString();

            return false;
        }
    }
}
