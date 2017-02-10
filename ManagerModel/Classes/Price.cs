namespace ManagerModel
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Price : Stock, IPrice
    {
        #region Constants and Variables

        private decimal _ask;
        private decimal _bid;
        private decimal _askRealTime;
        private decimal _bidRealTime;
        private decimal _previousClose;
        private decimal _open;

        #endregion Constants and Variables

        #region IPrice Members

        public decimal Ask
        {
            get
            {
                return _ask;
            }
            set
            {
                _ask = value;
            }
        }

        public decimal Bid
        {
            get
            {
                return _bid;
            }
            set
            {
                _bid = value;
            }
        }

        public decimal AskRealTime
        {
            get
            {
                return _askRealTime;
            }
            set
            {
                _askRealTime = value;
            }
        }

        public decimal BidRealTime
        {
            get
            {
                return _bidRealTime;
            }
            set
            {
                _bidRealTime = value;
            }
        }

        public decimal PreviousClose
        {
            get
            {
                return _previousClose;
            }
            set
            {
                _previousClose = value;
            }
        }

        public decimal Open
        {
            get
            {
                return _open;
            }
            set
            {
                _open = value;
            }
        }

        #endregion IPrice Members
    }
}
