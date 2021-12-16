using System;
using System.Collections;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportCorp
{
    [Serializable]
    class Airport_company:IPrintable
    {
        Dictionary<string, Tuple<int,int,int>> airorts = new Dictionary<string, Tuple<int, int, int>>();
        SortedList<string, Tuple<int, int, int>> airorts1 = new SortedList<string, Tuple<int, int, int>>();



        protected int count_of_airports { get; set; } = 0;

        


        public Airport_company()
        {

            airorts.Add("Киев", new Tuple<int, int, int> (0,0,0)) ;
            airorts1.Add("Киев", new Tuple<int, int, int>(0, 0, 0));
            count_of_airports++;
            
            airorts.Add("Лондон", new Tuple<int, int, int>(1, 1, 1));
            airorts1.Add("Лондон", new Tuple<int, int, int>(1, 1, 1));
            count_of_airports++;

            airorts.Add("Париж", new Tuple<int, int, int>(3, 3, 0));
            airorts1.Add("Париж", new Tuple<int, int, int>(3, 3, 0));

            count_of_airports++;

            airorts.Add("Камбоджа", new Tuple<int, int, int>(0, 10, 11));
            airorts1.Add("Камбоджа", new Tuple<int, int, int>(0, 10, 11));

            count_of_airports++;

            airorts.Add("Маями", new Tuple<int, int, int>(0, 0, 15));
            airorts1.Add("Маями", new Tuple<int, int, int>(0, 0, 15));

            count_of_airports++;

        }
        public Dictionary<string, Tuple<int, int, int>> Getairports()
        {
            return airorts;
        }
       
        public virtual string GetAll()
        {
            foreach(KeyValuePair<string, Tuple<int, int, int>> keyValue in airorts1)
            {
                Console.WriteLine($"{keyValue.Key} {keyValue.Value}");
            }
            return $" count_of_airports: {count_of_airports}";
        }
    }
}
