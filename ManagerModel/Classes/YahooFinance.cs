using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerModel
{
    public static class YahooFinance
    {
        public static List<Price> ParsePrice(string csvString, List<Stock> stocks)
        {
            List<Price> prices = new List<Price>();

            string[] rows = csvString.Replace("\r", "").Split('\n');

            for (int i = 0; i < rows.Length; i++ )
            {
                if (string.IsNullOrEmpty(rows[i]) || stocks[i] == null) continue;

                string[] cols = rows[i].Split(',');

                Price p = new Price();

                p.Symbol = stocks[i].Symbol;
                p.Name = stocks[i].Name;

                p.Bid = cols[0] != "N/A" ? Convert.ToDecimal(cols[0]) : 0;
                p.Ask = cols[1] != "N/A" ? Convert.ToDecimal(cols[1]) : 0;
                p.Open = Convert.ToDecimal(cols[2]);
                p.PreviousClose = Convert.ToDecimal(cols[3]);

                prices.Add(p);
            }

            return prices;
        }

        public static List<Stock> ParseStock(string csvString)
        {
            List<Stock> stocks = new List<Stock>();

            string[] rows = csvString.Replace("\r", "").Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row)) continue;

                string[] cols = row.Split(',');

                Stock s = new Stock();
                s.Symbol = cols[0].Trim('"');
                s.Name = cols[1].Trim('"');

                stocks.Add(s);
            }

            return stocks;

        }
    }
}
