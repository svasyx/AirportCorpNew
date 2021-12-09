using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportCorp
{
    [Serializable]
    class Airport_ : Airport_company, IPrintable
    {
        protected string town_ { set; get; } = "Home town";

        public Airport_(string town) : base()
        {
            town_ = town;
        }



        public Airport_(string town, int cost) : base()
        {
            town_ = town;
        }

        public override string GetAll()
        {
            return base.GetAll() + $" Count_of_lines: {town_}";
        }
    }
}
