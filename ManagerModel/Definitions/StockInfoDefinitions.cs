using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerModel
{

    //http://finance.yahoo.com/d/quotes.csv?s=AGEN+SRNE+TTD&f=nab


    /*  REFERENCING:
     *  http://www.jarloo.com/yahoo_finance/
     */

    public static class StockInfoDefinitions
    {

        //Symbols with "RT" denote "Real Time"

    }

    public static class StockInfoKeys
    {
        public static string Name = "n";

        public static string Symbol = "s";
    }

    public static class PriceInfoKeys
    {
        //Pricing

        public static string Ask = "a";

        public static string Bid = "b";

        public static string AskRT = "b2";

        public static string BidRT = "b3";

        public static string PreviousClose = "p";

        public static string Open = "o";
    }

    public static class DateInfoKeys
    {
        //Date
        
        public static string Change = "c1";

        public static string ChangeAndPercent = "c";

        public static string ChangeRT = "c6";

        public static string ChangePercentRT = "k2";

        public static string ChangeInPercent = "p2";
    }

    public static class AvgInfoKeys
    {
                //Averages

        public static string AfterHoursChange = "c8";

        public static string Commission = "c3";

        public static string DayLow = "g";

        public static string DayHigh = "h";

        public static string OneYearTargetPrice = "t8";
    }

}
