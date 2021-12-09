using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportCorp
{
    [Serializable]
    class Airport_company:IPrintable
    {
        Dictionary<string, int> airorts = new Dictionary<string, int>();

        
        protected int count_of_airports { get; set; } = 0;



        public Airport_company()
        {
            airorts.Add("Киев", 0);
            count_of_airports++;

            airorts.Add("Одеса", 580);
            count_of_airports++;

            airorts.Add("Харьков", 700);
            count_of_airports++;

            airorts.Add("Полтава", 340);
            count_of_airports++;

            airorts.Add("Винница", 100);
            count_of_airports++;

        }
        public Dictionary<string, int> Getairports()
        {
            return airorts;
        }
        public virtual string GetAll()
        {
            foreach(KeyValuePair<string,int> keyValue in airorts)
            {
                Console.WriteLine($"{keyValue.Key} {keyValue.Value}");
            }
            return $" count_of_airports: {count_of_airports}";
        }
    }
}
