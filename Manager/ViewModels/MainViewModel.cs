using ManagerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class MainViewModel
    {

        private List<String> _symbols
            = new List<string>() { "AGEN", "SRNE", "TTD", "NPTN", "MRAM" };

        public List<Price> Prices
        {
            get;
            set;
        }

        public List<Stock> Stocks
        {
            get;
            set;
        }

        public Price SelectedItem
        {
            get;
            set;
        }

        private void InitializeStocks()
        {
            string csvData;

            if (_symbols == null)
            {
                throw new Exception("Failed to retrieve symbols.");
            }

            string url = Definitions.YahooFinanceUrl;

            foreach (var symb in _symbols)
            {
                url += symb + "+";
            }

            url = url.TrimEnd('+') + "&f=";

            url = string.Format("{0}{1}{2}", url, StockInfoKeys.Symbol, StockInfoKeys.Name);

            using (WebClient web = new WebClient())
            {
                csvData = web.DownloadString(url);
            }

            Stocks = YahooFinance.ParseStock(csvData);
        }

        private void InitializePrices()
        {
            string csvData;

            if (Stocks == null)
            {
                throw new Exception("Failed to retrieve symbols.");
            }

            string url = Definitions.YahooFinanceUrl;

            foreach (var stock in Stocks)
            {
                url += stock.Symbol + "+";
            }

            url = url.TrimEnd('+') + "&f=";

            url = string.Format("{0}{1}{2}{3}{4}", url, PriceInfoKeys.Bid, PriceInfoKeys.Ask, PriceInfoKeys.Open, PriceInfoKeys.PreviousClose);

            using (WebClient web = new WebClient())
            {
                csvData = web.DownloadString(url);
            }

            Prices = YahooFinance.ParsePrice(csvData, Stocks);
        }

        private void Initialize()
        {
            InitializeStocks();

            InitializePrices();
        }

        public MainViewModel()
        {
            Initialize();
        }
    }
}
