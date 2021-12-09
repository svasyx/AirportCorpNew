using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportCorp
{
    [Serializable]
    class Bussinesman : Person, IPrintable, IBusinesmann
    {
        protected int _count_of_flight_ { set; get; } = 10000;
        protected int _count_of_people { set; get; } = 0;

        protected bool _is_all = false;

        protected int _capacity_of_plane { get; set; } = 10;

        public Bussinesman(string name, string surname) : base(name, surname)
        {

        }
        public Bussinesman(string name, string surname, bool is_all, int count_of_people) : base(name, surname)
        {
            
            _is_all = is_all;
            _count_of_people = count_of_people;
            
            
            

            if(_is_all)
            {
                _count_of_flight_ = 1000 * _capacity_of_plane;
            }
            else
            {
                _count_of_flight_ = 1000 * count_of_people;
            }
            
        }
        public override string GetAll()
        {
            return base.GetAll() + $"Count of $: {_count_of_flight_}";
        }
    }
}
