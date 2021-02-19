using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Test_Bank_PortFolio.Trades;

namespace WF_Test_Bank_PortFolio.Risk
{
    interface IRisk
    {
        string Type { get; }

        bool CalculaRisk(ITrade trade);
    }
}
