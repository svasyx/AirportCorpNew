using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportCorp
{
    [Serializable]
    internal class Airport
    {
        protected string _town { set; get; } = "Home town";

        public Airport(string town) 
        {
            _town = town;
        }



        public Airport() 
        {
            _town = "Kyiv";
        }

        public string GetTown()
        {
            return _town;
        }
        public string GetAll()
        {
            return $"{ _town}";
        }
    }
}
