using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Test_Bank_PortFolio.Risk;



namespace WF_Test_Bank_PortFolio.Trades
{
    class Trade : ITrade
    {
        private static int IDtrade = 1;

        private string name;

        public double Value { get; set; }
        public string ClientSector { get; set; }

        public Trade()
        {
            this.name = "Trade" + IDtrade++;
        }

        public bool CalculaRisk(IRisk risk)
        {
            return risk.CalculaRisk(this);
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
