using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Test_Bank_PortFolio.Risk
{
    static class FactoryRisk
    {
        public static IRisk Create(TypeRisk risk)
        {
            return Create(risk.ToString());
        }

        public static IRisk Create(string risk)
        {
            switch (risk)
            {
                case "LowRisk":
                    return new LowRisk();
                case "MediumRisk":
                    return new MediumRisk();
                case "HighRisk":
                    return new HighRisk();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
