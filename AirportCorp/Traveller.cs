using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;


namespace AirportCorp
{
    [Serializable]
    public class Traveller : Person, IPrintable, ITraveler, IComparable<Traveller>
    {

        protected string _from { get; set; } = "home";
        protected string _to { get; set; } = "home";
        protected int _time_of_travel { get; set; } = 0;
        protected bool _laggage = false;
        protected bool _visa = false;
        protected double _visa_price;
        protected double _distance;
        protected double _cost_of_travel;
        protected int _price_of_travel = 130;
        protected double _from_e;
        protected double _to_e;


        protected DateTime _arr { get; set; } = DateTime.Now;
        protected DateTime _dep { get; set; } = DateTime.Now;

        public delegate double Price(double distance, double price_of_travel, double visa_price);
        public event Price PriceHandler;


        Airport_company airport_Company = new Airport_company();

        public Traveller() : base("name", "surname")
        {

        }

        public int CompareTo(Traveller tr)
        {
            return _name.CompareTo(tr._name);
        }


        public Traveller(string name, string surname, string from, string to, int time_of_travel, bool laggage, bool visa, DateTime arr, DateTime dep) : base(name, surname)
        {

            if (dep.Day - arr.Day < 0 || dep.Month - arr.Month < 0 && arr.Year == DateTime.Today.Year)
            {
                throw new dateException("Виберіть правильну дату!!!", arr);
            }
            else
            {
                _arr = arr;
                _dep = dep;
            }
            if (time_of_travel < 0)
            {

                throw new minusException("Не може бути менше за нуль!", time_of_travel);
            }
            else
            {
                _time_of_travel = time_of_travel;
            }

            if (from == to)
            {
                throw new cityException("Міста не можуть бути однаковими", from);
            }
            else
            {
                _from = from;
                _to = to;
            }

            _laggage = laggage;
            _visa = visa;
            _name = name;


           // PriceHandler += Price1;
        }

        public double GetDistanse()
        {
            foreach (KeyValuePair<string, Tuple<int, int, int>> key in airport_Company.Getairports())
            {
                if (key.Key == _from)
                {
                    _from_e = Sqrt((Pow(key.Value.Item1, 2) + Pow(key.Value.Item2, 2) + Pow(key.Value.Item3, 2)));
                }
                if (key.Key == _to)
                {
                    _to_e = Sqrt((Pow(key.Value.Item1, 2) + Pow(key.Value.Item2, 2) + Pow(key.Value.Item3, 2)));

                }
            }

            _distance = Sqrt(Pow(_from_e, 2) + Pow(_to_e, 2));

            return _distance;
        }
     

        public double GetVisaPrice()
        {

            if (_visa == true)
            {
                _visa_price = 0;

            }
            else
            {
                _visa_price = 130 * _time_of_travel;
            }
            return _visa_price;
        }
        public double GetPrice()
        {
            if (_laggage)
            {
                _cost_of_travel = (double)PriceHandler?.Invoke(GetDistanse(), _price_of_travel * 1.005, GetVisaPrice());
            }
            else
            {
                _cost_of_travel = (double)PriceHandler?.Invoke(GetDistanse(), _price_of_travel, GetVisaPrice());
            }
            return _cost_of_travel;
        }


        public override string GetAll()
        {

            return base.GetAll() + $"{_from} - {_to},  {_time_of_travel} днів, Ціна за квиток: {GetPrice()}";
        }

        //public double Price1(double distance, double price_of_travel, double visa_price)
        //{
        //    return distance * price_of_travel + visa_price;
        //}

    }
}