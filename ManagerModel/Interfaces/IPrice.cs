namespace ManagerModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IPrice : IStock
    {
        decimal Ask
        {
            get;
            set;
        }

        decimal Bid
        {
            get;
            set;
        }

        decimal AskRealTime
        {
            get;
            set;
        }

        decimal BidRealTime
        {
            get;
            set;
        }

        decimal PreviousClose
        {
            get;
            set;
        }

        decimal Open
        {
            get;
            set;
        }
    }

}
