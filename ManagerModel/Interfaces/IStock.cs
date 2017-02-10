namespace ManagerModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IStock
    {
        string Symbol
        {
            get;
            set;
        }

        string Name
        {
            get;
            set;
        }
    }
}
