using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Test_Bank_PortFolio.Categories;
using WF_Test_Bank_PortFolio.Trades;


namespace WF_Test_Bank_PortFolio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //Identify the categories of trades in a bank´s portfolio.
            IdentifyCategoryTradeBankPortFolio();
            
        }

        void IdentifyCategoryTradeBankPortFolio()
        {
            List<ITrade> portfolio;
            List<string> tradeCategories;

            Trade trade1 = new Trade { Value = 2000000, ClientSector = "Private" };
            Trade trade2 = new Trade { Value = 400000, ClientSector = "Public" };
            Trade trade3 = new Trade { Value = 500000, ClientSector = "Public" };
            Trade trade4 = new Trade { Value = 3000000, ClientSector = "Public" };

            portfolio = new List<ITrade> { trade1, trade2, trade3, trade4 };

            tradeCategories = new Category(portfolio).GetCategories();

            StringBuilder sb = new StringBuilder();
            foreach (ITrade trade in portfolio)
            {
               
                sb.AppendLine(string.Format("{0} = {{Value = {1}, ClientSector = \"{2}\" }}", (Trade)trade, trade.Value, trade.ClientSector));
                
                textBox2.Text = sb.ToString();

            }
           

            sb.AppendLine(string.Format("portfolio = {{ {0}, {1}, {2}, {3} }}", trade1, trade2, trade3, trade4));

            textBox2.Text = sb.ToString();

            StringBuilder sb2 = new StringBuilder();
            sb2.AppendLine(string.Format("tradeCategories = {{ \"{0}\", \"{1}\", \"{2}\", \"{3}\" }}", tradeCategories[0], tradeCategories[1], tradeCategories[2], tradeCategories[3]));

            textBox1.Text = sb2.ToString();
    

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }
    }
   
}

