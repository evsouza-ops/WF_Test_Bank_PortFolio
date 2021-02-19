using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Test_Bank_PortFolio.Trades
{
    interface ITrade
    {
        double Value { get; }
        string ClientSector { get; }
    }
}
