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
        //поля класу
        protected string _town { set; get; } = "Home town";




        //конструктори класу
        public Airport(string town) 
        {
            _town = town;
        }



        public Airport() 
        {
            _town = "Kyiv";
        }



        //гетери
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
