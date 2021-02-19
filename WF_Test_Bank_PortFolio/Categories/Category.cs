using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Test_Bank_PortFolio.Risk;
using WF_Test_Bank_PortFolio.Trades;
using WF_Test_Bank_PortFolio.Categories;


namespace WF_Test_Bank_PortFolio.Categories
{
    class Category
    {
        private List<ITrade> portfolio;

        public Category(List<ITrade> portfolio)
        {
            this.portfolio = portfolio;
        }

        public List<string> GetCategories()
        {
            IRisk risk = null;

            List<string> tradeCategories = new List<string>();

            List<IRisk> risks = new List<IRisk> {
                FactoryRisk.Create(TypeRisk.LowRisk),
                FactoryRisk.Create(TypeRisk.MediumRisk),
                FactoryRisk.Create(TypeRisk.HighRisk)
            };

            foreach (Trade trade in portfolio)
            {
                foreach (IRisk risco in risks)
                {
                    risk = risco;

                    if (trade.CalculaRisk(risco))
                    {
                        break;
                    }
                }

                tradeCategories.Add(risk.Type);
            }

            return tradeCategories;
        }
    }
}
